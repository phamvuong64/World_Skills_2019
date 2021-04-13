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
import 'package:session1/models/employees.dart';
import 'package:session1/models/image_asset.dart';
import 'package:session1/ui/custom_ui.dart';

class EditingScreen extends StatefulWidget {
  final AppBloc appBloc;
  final int index;

  EditingScreen(this.appBloc, this.index);

  @override
  State<StatefulWidget> createState() => EditingScreenState();
}

class EditingScreenState extends State<EditingScreen> {
  final _globalKey = new GlobalKey<ScaffoldState>();
  final txtAssetName = TextEditingController();
  final txtDepartment = TextEditingController();
  final txtLocation = TextEditingController();
  final txtAssetGroup = TextEditingController();
  final txtAssetSN = TextEditingController();
  final txtDescription = TextEditingController();
  final txtWarrantyDate = TextEditingController();
  Employees _employees;
  String eName;
  List<ImageAsset> listImg = [];
  int oldListImgLength;

  String asn;

  @override
  void initState() {
    txtAssetName.text = widget.appBloc.listAssets[widget.index].an;
    txtDepartment.text = widget.appBloc.listAssets[widget.index].dn;
    txtLocation.text = widget.appBloc.listAssets[widget.index].ln;
    txtAssetGroup.text = widget.appBloc.listAssets[widget.index].agn;
    txtDescription.text = widget.appBloc.listAssets[widget.index].des;
    DateTime dateTime = widget.appBloc.listAssets[widget.index].wd;
    txtWarrantyDate.text =
        dateTime == null ? '' : DateFormat("yyyy-MM-dd").format(dateTime);
    if (widget.appBloc.listAssets[widget.index].ap != "") {
      listImg.add(
        ImageAsset(
            name: 'Picture Asset',
            img: widget.appBloc.listAssets[widget.index].ap),
      );
      oldListImgLength = 1;
    } else {
      oldListImgLength = 0;
    }

    asn = widget.appBloc.listAssets[widget.index].asn;

    super.initState();
  }

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
                'Editing Error',
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
                                SizedBox(
                                  width: MediaQuery.of(context).size.width * 0.4,
                                  child: TextField(
                                    controller: txtDepartment,
                                    readOnly: true,
                                    decoration:
                                    InputDecoration(labelText: 'Departments'),
                                  ),
                                ),
                                SizedBox(
                                  width: MediaQuery.of(context).size.width * 0.4,
                                  child: TextField(
                                    controller: txtLocation,
                                    readOnly: true,
                                    decoration: InputDecoration(labelText: 'Locations'),
                                  ),
                                ),
                              ],
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              crossAxisAlignment: CrossAxisAlignment.end,
                              children: <Widget>[
                                SizedBox(
                                  width: MediaQuery.of(context).size.width * 0.4,
                                  child: TextField(
                                    controller: txtLocation,
                                    readOnly: true,
                                    decoration:
                                    InputDecoration(labelText: 'Asset Group'),
                                  ),
                                ),
                                DropdownButton<Employees>(
                                  hint: Text(
                                      widget.appBloc.listAssets[widget.index].eName),
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
                                  labelText: 'Asset Description',
                                  hintText: 'Multi Line'),
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: <Widget>[
                                SizedBox(
                                  width: 170,
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
                                      asn,
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
                            widget.appBloc.add(DoEditing(
                                txtAssetName.text,
                                _employees,
                                txtDescription.text,
                                txtWarrantyDate.text,
                                listImg,
                                oldListImgLength,
                                widget.index));
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
                    ),
                  ),
                ),
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
