import 'dart:convert';
import 'dart:async';
import 'dart:typed_data';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:image_picker/image_picker.dart';
import 'package:intl/intl.dart';
import 'package:session1/bloc/app_bloc.dart';
import 'package:session1/bloc/app_event.dart';
import 'package:session1/bloc/app_state.dart';
import 'package:session1/models/assets_group.dart';
import 'package:session1/models/departments.dart';
import 'package:session1/models/employees.dart';
import 'package:session1/models/image_asset.dart';
import 'package:session1/models/locations.dart';
import 'package:session1/ui/custom_ui.dart';

class RegisteringScreen extends StatefulWidget {
  final AppBloc appBloc;

  RegisteringScreen(this.appBloc);

  @override
  State<StatefulWidget> createState() => RegisteringScreenState();
}

class RegisteringScreenState extends State<RegisteringScreen> {
  final _globalKey = new GlobalKey<ScaffoldState>();
  final txtAssetName = TextEditingController();
  final txtAssetSN = TextEditingController();
  final txtDescription = TextEditingController();
  final txtWarrantyDate = TextEditingController();

  Departments _departments;
  Locations _locations;
  AssetsGroup _assetsGroup;
  Employees _employees;

  List<ImageAsset> listImg = [];

  String dd = 'dd';
  String gg = 'gg';
  String asn;

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Scaffold(
        key: _globalKey,
        appBar: CustomUi.customAppBar(context, 'Asset Information'),
        body: _buildBody(),
      ),
    );
  }

  Widget _buildBody() {
    return BlocListener(
      bloc: widget.appBloc,
      listener: (context, state) {
        if (state is PostSuccess) {
          Navigator.pop(context, true);
        }

        if (state is PostErrorValidateAll) {
          _globalKey.currentState.showSnackBar(
            SnackBar(
              content: Text(
                'All the fields except for the warranty date range and images should be filled out before the form can be submitted.',
              ),
            ),
          );
        }

        if (state is PostErrorDuplicateData) {
          _globalKey.currentState.showSnackBar(
            SnackBar(
              content: Text(
                'Two assets of the same name in the same location is not true',
              ),
            ),
          );
        }

        if (state is PostError) {
          _globalKey.currentState.showSnackBar(
            SnackBar(
              content: Text(
                'Registering Error',
              ),
            ),
          );
        }
      },
      child: BlocBuilder(
        bloc: widget.appBloc,
        builder: (context, state) {
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
                            TextField(
                              controller: txtAssetName,
                              decoration: InputDecoration(labelText: 'Asset Name'),
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: <Widget>[
                                DropdownButton<Departments>(
                                  hint: Text('Departments'),
                                  value: _departments,
                                  onChanged: (Departments d) {
                                    setState(() {
                                      _departments = d;
                                      widget.appBloc.add(DoLoadLocation(_departments.id));
                                      if (_assetsGroup != null) {
                                        widget.appBloc.add(DoLoadAssetSN(
                                            _departments.id, _assetsGroup.id));
                                      }
                                    });
                                  },
                                  items: widget.appBloc.listDepartments
                                      .map<DropdownMenuItem<Departments>>(
                                          (e) => DropdownMenuItem(
                                        value: e,
                                        child: Text(e.name),
                                      ))
                                      .toList(),
                                ),
                                DropdownButton<Locations>(
                                  hint: Text('Locations'),
                                  value: _locations,
                                  onChanged: (Locations l) {
                                    setState(() {
                                      _locations = l;
                                    });
                                  },
                                  items: widget.appBloc.listLocations
                                      .map<DropdownMenuItem<Locations>>(
                                          (e) => DropdownMenuItem(
                                        value: e,
                                        child: Text(e.name),
                                      ))
                                      .toList(),
                                )
                              ],
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: <Widget>[
                                DropdownButton<AssetsGroup>(
                                  hint: Text('Asset Group'),
                                  value: _assetsGroup,
                                  onChanged: (AssetsGroup ag) {
                                    setState(() {
                                      _assetsGroup = ag;
                                      if (_departments != null) {
                                        widget.appBloc.add(DoLoadAssetSN(
                                            _departments.id, _assetsGroup.id));
                                      }
                                    });
                                  },
                                  items: widget.appBloc.listAssetGroups
                                      .map<DropdownMenuItem<AssetsGroup>>(
                                          (e) => DropdownMenuItem(
                                        value: e,
                                        child: Text(e.name),
                                      ))
                                      .toList(),
                                ),
                                DropdownButton<Employees>(
                                  hint: Text('Accountable Party'),
                                  value: _employees,
                                  onChanged: (Employees em) {
                                    setState(() {
                                      _employees = em;
                                    });
                                  },
                                  items: widget.appBloc.listEmployees
                                      .map<DropdownMenuItem<Employees>>(
                                          (e) => DropdownMenuItem(
                                        value: e,
                                        child: Text(e.fullName),
                                      ))
                                      .toList(),
                                )
                              ],
                            ),
                            TextField(
                              controller: txtDescription,
                              keyboardType: TextInputType.multiline,
                              maxLines: 2,
                              decoration: InputDecoration(
                                  labelText: 'Asset Description', hintText: 'Multi Line'),
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: <Widget>[
                                SizedBox(
                                  width: 180,
                                  child: TextField(
                                    controller: txtWarrantyDate,
                                    readOnly: true,
                                    decoration: InputDecoration(
                                        labelText: 'Expired Warranty',
                                        icon: Icon(Icons.calendar_today)),
                                    onTap: () {
                                      showDatePicker(
                                        context: context,
                                        initialDate: DateTime.now(),
                                        firstDate: DateTime(1900),
                                        lastDate: DateTime(3000),
                                      ).then((value) {
                                        setState(() {
                                          txtWarrantyDate.text = value == null
                                              ? ''
                                              : DateFormat("yyyy-MM-dd").format(value);
                                        });
                                      });
                                    },
                                  ),
                                ),
                                Row(
                                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                                  children: <Widget>[
                                    Text('Asset SN:  '),
                                    Text(
                                      widget.appBloc.asn,
                                      style: TextStyle(fontWeight: FontWeight.bold),
                                    ),
                                  ],
                                ),
                              ],
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.end,
                              children: <Widget>[
                                RaisedButton(
                                  child: Text('Capture Image'),
                                  onPressed: () {
                                    _captureImage();
                                  },
                                ),
                                SizedBox(width: 20),
                                RaisedButton(
                                  child: Text('Browse'),
                                  onPressed: () {
                                    _browseImage();
                                  },
                                )
                              ],
                            ),
                          ],
                        ),
                      ),
                      SliverList(
                        delegate: SliverChildBuilderDelegate(
                                (BuildContext context, int index) {
                              return Card(
                                child: SizedBox(

                                  child: Row(
                                    children: <Widget>[
                                      Image(
                                        image:
                                        MemoryImage(base64Decode(listImg[index].img)),
                                        height: 70,
                                        width: 70,
                                        fit: BoxFit.cover,
                                      ),
                                      SizedBox(width: 20),
                                      Expanded(
                                        child: Text(listImg[index].name),
                                      ),
                                    ],
                                  ),
                                ),
                              );
                            }, childCount: listImg.length),
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
                              style: TextStyle(color: Colors.blue),
                            ),
                            onTap: () {
                              widget.appBloc.add(
                                DoPostRegistering(
                                  department: _departments,
                                  locations: _locations,
                                  asn: widget.appBloc.asn,
                                  an: txtAssetName.text,
                                  employees: _employees,
                                  assetsGroup: _assetsGroup,
                                  dsc: txtDescription.text,
                                  wd: txtWarrantyDate.text,
                                  listImg: listImg,
                                ),
                              );
                            },
                          ),
                          SizedBox(width: 40),
                          InkWell(
                            child: Text(
                              'CANCEL',
                              style: TextStyle(color: Colors.blue),
                            ),
                            onTap: () {
                              Navigator.pop(context);
                            },
                          ),
                        ],
                      )
                  ),
                )
              ],
            ),
          );
        },
      ),
    );
  }

  Future _captureImage() async {
    var imgPick = await ImagePicker().getImage(
      source: ImageSource.camera,
      imageQuality: 50,
    );

    if (imgPick != null) {
      String imgName = imgPick.path.split('/').last;
      Uint8List img = await imgPick.readAsBytes();
      String img64 = base64Encode(img);
      setState(() {
        listImg.add(ImageAsset(name: imgName, img: img64));
      });
    }
  }

  Future _browseImage() async {
    var imgPick = await ImagePicker().getImage(
      source: ImageSource.gallery,
      imageQuality: 50,
    );

    if (imgPick != null) {
      String imgName = imgPick.path.split('/').last;
      Uint8List img = await imgPick.readAsBytes();
      String img64 = base64.encode(img);
      setState(
        () {
          listImg.add(ImageAsset(name: imgName, img: img64));
        },
      );
    }
  }
}
