import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:session1/bloc/app_bloc.dart';
import 'package:session1/bloc/app_event.dart';
import 'package:session1/bloc/app_state.dart';
import 'package:session1/models/departments.dart';
import 'package:session1/models/locations.dart';

import 'custom_ui.dart';

class TransfersScreen extends StatefulWidget {
  final AppBloc appBloc;
  final int index;

  const TransfersScreen(this.appBloc, this.index);

  @override
  State<StatefulWidget> createState() => TransfersScreenState();
}

class TransfersScreenState extends State<TransfersScreen> {
  final _globalKey = GlobalKey<ScaffoldState>();
  final txtAssetName = TextEditingController();
  final txtAssetSNOld = TextEditingController();
  final txtDepartment = TextEditingController();
  final txtAssetSNNew = TextEditingController();

  Departments _departments;
  Locations _locations;

  @override
  void initState() {
    txtAssetName.text = widget.appBloc.listAssets[widget.index].an;
    txtDepartment.text = widget.appBloc.listAssets[widget.index].dn;
    txtAssetSNOld.text = widget.appBloc.listAssets[widget.index].asn;

    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Scaffold(
        key: _globalKey,
          appBar: CustomUi.customAppBar(context, 'Asset Transfers'),
          body: BlocListener(
            bloc: widget.appBloc,
            listener: (context, state){
              if (state is PostSuccess) {
                Navigator.pop(context, true);
              }

              if (state is PostErrorValidateAll) {
                _globalKey.currentState.showSnackBar(
                  SnackBar(
                    content: Text(
                      'All the fields should be filled out before the form can be submitted.',
                    ),
                  ),
                );
              }
            },
            child: BlocBuilder(
              bloc: widget.appBloc,
              builder: (context, state) {
                txtAssetSNNew.text = widget.appBloc.asn;
                return Padding(
                  padding: const EdgeInsets.fromLTRB(10, 0, 10, 0),
                  child: Stack(
                    children: <Widget>[
                      Container(
                        margin: EdgeInsets.only(bottom: 48),
                        child: CustomScrollView(
                          slivers: <Widget>[
                            SliverToBoxAdapter(
                              child: Column(
                                children: <Widget>[
                                  TextFormField(
                                    initialValue: 'Selected Asset',
                                    readOnly: true,
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                    children: <Widget>[
                                      SizedBox(
                                        width: MediaQuery.of(context).size.width * 0.41,
                                        child: TextField(
                                          controller: txtAssetName,
                                          readOnly: true,
                                          decoration:
                                          InputDecoration(labelText: 'Asset Name:'),
                                        ),
                                      ),
                                      SizedBox(
                                        width: MediaQuery.of(context).size.width * 0.41,
                                        child: TextField(
                                          controller: txtDepartment,
                                          readOnly: true,
                                          decoration: InputDecoration(
                                              labelText: 'Current Department:'),
                                        ),
                                      ),
                                    ],
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.start,
                                    children: <Widget>[
                                      SizedBox(
                                        width: MediaQuery.of(context).size.width * 0.41,
                                        child: TextField(
                                          controller: txtAssetSNOld,
                                          readOnly: true,
                                          decoration:
                                          InputDecoration(labelText: 'Asset SN:'),
                                        ),
                                      ),
                                    ],
                                  ),
                                  TextFormField(
                                    initialValue: 'Destination Department',
                                    readOnly: true,
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                    children: <Widget>[
                                      SizedBox(
                                        width: MediaQuery.of(context).size.width * 0.45,
                                        child: DropdownButton<Departments>(
                                          hint: Text(
                                            'Destination Department',
                                            style: TextStyle(
                                              fontSize: 13,
                                            ),
                                          ),
                                          value: _departments,
                                          onChanged: (Departments d) {
                                            setState(() {
                                              _departments = d;
                                            });
                                            widget.appBloc
                                                .add(DoLoadLocation(_departments.id));
                                            widget.appBloc.add(
                                              DoLoadAssetSN(
                                                _departments.id,
                                                widget
                                                    .appBloc.listAssets[widget.index].agID,
                                              ),
                                            );
                                          },
                                          items: widget.appBloc.listDepartments
                                              .map<DropdownMenuItem<Departments>>((e) {
                                            return DropdownMenuItem(
                                              value: e,
                                              child: Text(e.name),
                                            );
                                          }).toList(),
                                        ),
                                      ),
                                      SizedBox(
                                        width: MediaQuery.of(context).size.width * 0.45,
                                        child: DropdownButton<Locations>(
                                          hint: Text(
                                            'Destination Location',
                                            style: TextStyle(
                                              fontSize: 13,
                                            ),
                                          ),
                                          value: _locations,
                                          onChanged: (Locations l) {
                                            setState(() {
                                              _locations = l;
                                            });
                                          },
                                          items: widget.appBloc.listLocations
                                              .map<DropdownMenuItem<Locations>>((e) {
                                            return DropdownMenuItem(
                                              value: e,
                                              child: Text(e.name),
                                            );
                                          }).toList(),
                                        ),
                                      ),
                                    ],
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.start,
                                    children: <Widget>[
                                      SizedBox(
                                        width: MediaQuery.of(context).size.width * 0.41,
                                        child: TextField(
                                          controller: txtAssetSNNew,
                                          readOnly: true,
                                          decoration:
                                          InputDecoration(labelText: 'New Asset SN:'),
                                        ),
                                      ),
                                    ],
                                  ),

                                ],
                              ),
                            )
                          ],
                        ),
                      ),
                      Positioned(
                        bottom: 0,
                        right: 0,
                        child: Container(
                          height: 48,
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.end,
                            children: <Widget>[
                              InkWell(
                                child: Text(
                                  'Submit',
                                  style: TextStyle(
                                    color: Colors.blue,
                                  ),
                                ),
                                onTap: () {
                                  widget.appBloc.add(
                                    DoTransfers(
                                      aID: widget
                                          .appBloc.listAssets[widget.index].id,
                                      asnOld: txtAssetSNOld.text,
                                      asnNew: txtAssetSNNew.text,
                                      dlIDOld: widget
                                          .appBloc.listAssets[widget.index].dlID,
                                      departments: _departments,
                                      locations: _locations,
                                      date: DateFormat("yyyy-MM-dd").format(DateTime.now()),
                                    ),
                                  );
                                },
                              ),
                              SizedBox(width: 40),
                              InkWell(
                                child: Text(
                                  'CANCEL',
                                  style: TextStyle(
                                    color: Colors.blue,
                                  ),
                                ),
                                onTap: () {
                                  Navigator.pop(context);
                                },
                              ),
                            ],
                          ),
                        ),
                      ),
                    ],
                  ),
                );
              },
            ),
          ),
      ),
    );
  }
}
