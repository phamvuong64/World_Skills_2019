import 'dart:convert';
import 'dart:typed_data';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:session1/bloc/app_bloc.dart';
import 'package:session1/bloc/app_event.dart';
import 'package:session1/bloc/app_state.dart';
import 'package:session1/main.dart';
import 'package:session1/models/assets_group.dart';
import 'package:session1/models/departments.dart';
import 'package:session1/ui/editing.dart';
import 'package:session1/ui/registering.dart';
import 'package:session1/ui/transfer_history.dart';
import 'package:session1/ui/transfers.dart';

class AssetCatalogueScreen extends StatefulWidget {
  @override
  _AssetCatalogueScreenState createState() => _AssetCatalogueScreenState();
}

class _AssetCatalogueScreenState extends State<AssetCatalogueScreen> {
  final _globalKey = new GlobalKey<ScaffoldState>();

  final txtStartDate = TextEditingController();
  final txtEndDate = TextEditingController();
  final txtSearch = TextEditingController();

  AppBloc _appBloc;

  Departments valueDepart;
  AssetsGroup valueAG;

  bool isPortrait;
  double mainHeight;

  @override
  void initState() {
    _appBloc = new AppBloc();
    _appBloc.add(DoLoadDataAssetsList());
    _appBloc.add(DoLoadDataDropDow());
    super.initState();
  }

  @override
  void dispose() {
    _appBloc.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    mainHeight = MediaQuery.of(context).size.height;
    MediaQuery.of(context).orientation == Orientation.portrait
        ? isPortrait = true
        : isPortrait = false;
    return SafeArea(
      child: Scaffold(
        key: _globalKey,
        body: _buildBody(),
      ),
    );
  }

  Widget _buildBody() {
    return BlocBuilder(
      bloc: _appBloc,
      builder: (context, AppState state) {
        return Padding(
          padding: const EdgeInsets.fromLTRB(10, 30, 10, 10),
          child: Stack(
            children: <Widget>[
              Container(
                margin: EdgeInsets.only(bottom: 40),
                child: CustomScrollView(
                  slivers: <Widget>[
                    SliverToBoxAdapter(
                      child: isPortrait
                          ? _buildBodyPortrait()
                          : _buildBodyLandscape(),
                    ),
                    SliverList(
                      delegate: SliverChildListDelegate([
                        ConstrainedBox(
                          constraints:
                              BoxConstraints(maxHeight: 400, minHeight: 250.0),
                          child: _buildListView(),
                        ),
                      ]),
                    ),
                  ],
                ),
              ),
              Positioned(
                bottom: 0,
                right: 10,
                left: 10,
                child: _buildFooter(),
              )
            ],
          ),
        );
      },
    );
  }

  Widget _buildBodyPortrait() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: <Widget>[
            DropdownButton<Departments>(
              hint: Text('Department'),
              value: valueDepart,
              onChanged: (Departments newValue) {
                setState(() {
                  valueDepart = newValue;
                  _filterListFromString(newValue.name);
                });
              },
              items: _appBloc.listDepartments
                  .map<DropdownMenuItem<Departments>>((e) {
                return DropdownMenuItem(
                  value: e,
                  child: Text(e.name),
                );
              }).toList(),
            ),
            DropdownButton<AssetsGroup>(
              hint: Text('Assets Group'),
              value: valueAG,
              onChanged: (AssetsGroup newValue) {
                setState(() {
                  valueAG = newValue;
                  _filterListFromString(newValue.name);
                });
              },
              items: _appBloc.listAssetGroups
                  .map<DropdownMenuItem<AssetsGroup>>((e) {
                return DropdownMenuItem(
                  value: e,
                  child: Text(e.name),
                );
              }).toList(),
            ),
          ],
        ),
        SizedBox(height: mainHeight * 0.02),
        TextFormField(
          initialValue: 'Warranty date range:',
          readOnly: true,
        ),
        SizedBox(height: mainHeight * 0.02),
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: <Widget>[
            _buildDatePicker("Start Date", txtStartDate),
            _buildDatePicker("End Date", txtEndDate),
          ],
        ),
        SizedBox(height: mainHeight * 0.02),
        TextField(
          controller: txtSearch,
          decoration: InputDecoration(
            hintText: 'Search...',
            prefixIcon: Icon(Icons.search),
          ),
          onChanged: (text) {
            setState(() {
              _filterListFromString(text);
            });
          },
        ),
        SizedBox(height: mainHeight * 0.04),
        Text(
          'Asset list:',
          style: TextStyle(
            fontSize: 11.0,
            fontWeight: FontWeight.bold,
          ),
        ),
      ],
    );
  }

  Widget _buildBodyLandscape() {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        Text(
          'Your list:',
          style: TextStyle(
            fontSize: 11.0,
            fontWeight: FontWeight.bold,
          ),
        ),
      ],
    );
  }

  Widget _buildDatePicker(String label, TextEditingController controller) {
    return SizedBox(
      width: 135,
      child: TextField(
        controller: controller,
        readOnly: true,
        decoration: InputDecoration(
          labelText: label,
          icon: Icon(Icons.calendar_today),
        ),
        onTap: () {
          showDatePicker(
            context: context,
            initialDate: DateTime.now(),
            firstDate: DateTime(1900),
            lastDate: DateTime(3000),
          ).then((value) {
            setState(() {
              controller.text =
                  value == null ? '' : DateFormat('yyyy-MM-dd').format(value);
              _filterListFromDate();
            });
          });
        },
      ),
    );
  }

  Widget _buildListView() {
    return Padding(
      padding: const EdgeInsets.fromLTRB(10.0, 10.0, 10.0, 5.0),
      child: RefreshIndicator(
        onRefresh: _refreshList,
        child: ListView.builder(
            itemCount: _appBloc.listFilter.length,
            itemBuilder: (context, int index) {
              return _buildItemList(index);
            }),
      ),
    );
  }

  Widget _buildItemList(int index) {
    return Card(
      margin: EdgeInsets.fromLTRB(0.0, 0.0, 0.0, 10.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: <Widget>[
          Row(
            children: <Widget>[
              SizedBox(
                height: 50,
                width: 50,
                child: Padding(
                  padding: EdgeInsets.fromLTRB(0.0, 3.0, 3.0, 3.0),
                  child: CircleAvatar(
                    backgroundColor: Colors.blueGrey,
                    backgroundImage: _appBloc.listFilter[index].ap != ""
                        ? MemoryImage(
                            base64Decode(_appBloc.listFilter[index].ap),
                          )
                        : AssetImage('assets/images/avatar_default.png'),
                  ),
                ),
              ),
              SizedBox(
                width: 120,
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    Text(
                      '${_appBloc.listFilter[index].an}',
                      style: TextStyle(fontWeight: FontWeight.bold),
                    ),
                    Text('${_appBloc.listFilter[index].dn}'),
                    Text('${_appBloc.listFilter[index].asn}'),
                  ],
                ),
              )
            ],
          ),
          Row(
            children: <Widget>[
              IconButton(
                icon: Icon(Icons.edit),
                onPressed: () {
                  _customNavigator(EditingScreen(_appBloc, index));
                },
              ),
              IconButton(
                icon: Icon(Icons.redo),
                onPressed: () {
                  _customNavigator(TransfersScreen(_appBloc, index));
                },
              ),
              IconButton(
                icon: Icon(Icons.menu),
                onPressed: () {
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) => TransferHistoryScreen(
                        appBloc: _appBloc,
                        aID: _appBloc.listAssets[index].id,
                      ),
                    ),
                  );
                },
              ),
            ],
          ),
        ],
      ),
    );
  }

  Widget _buildFooter() {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: <Widget>[
        Text(
          '${_appBloc.listFilter.length} assets from ${_appBloc.listAssets.length}',
          style: TextStyle(
            fontSize: 11.0,
            fontWeight: FontWeight.bold,
          ),
        ),
        FloatingActionButton(
          onPressed: () {
            _customNavigator(RegisteringScreen(_appBloc));
          },
          tooltip: 'Increment',
          child: Icon(Icons.add),
        )
      ],
    );
  }

  Future<Null> _refreshList() async {
    await Future.delayed(Duration(seconds: 2));
    _appBloc.add(DoLoadDataAssetsList());
    return null;
  }

  _filterListFromString(String text) {
    _appBloc.listFilter = _appBloc.listAssets
        .where((listAssetsItem) =>
            (
                listAssetsItem.asn.toLowerCase().contains(text.toLowerCase()) ||
                listAssetsItem.an.toLowerCase().contains(text.toLowerCase()) ||
                listAssetsItem.dn.toLowerCase().contains(text.toLowerCase()) ||
                listAssetsItem.agn.toLowerCase().contains(text.toLowerCase())
            ))
        .toList();
  }

  _filterListFromDate() {
    if (txtStartDate.text.isNotEmpty & txtEndDate.text.isNotEmpty) {
      DateTime starDate = DateTime.parse(txtStartDate.text);
      DateTime endDate = DateTime.parse(txtEndDate.text);
      if (endDate.isBefore(starDate)) {
        txtEndDate.text = '';
        _globalKey.currentState.showSnackBar(
          SnackBar(
            content: Text('End Date before Start Date is not true'),
          ),
        );
      } else {
        _appBloc.listFilter = _appBloc.listAssets
            .where((e) => (e.wd != null &&
                e.wd.isAfter(starDate) &&
                e.wd.isBefore(endDate)))
            .toList();
      }
    }
  }

  _customNavigator(Widget widget) async {
    final rl = await Navigator.push(
          context,
          CupertinoPageRoute(
            builder: (context) => widget,
          ),
        ) ??
        false;
    if (rl) {
      _appBloc.add(DoLoadDataAssetsList());
      _appBloc.add(DoResetASN());
    } else {
      _appBloc.add(DoResetASN());
    }
  }
}
