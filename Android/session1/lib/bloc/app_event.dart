import 'package:flutter/cupertino.dart';
import 'package:session1/models/assets_group.dart';
import 'package:session1/models/departments.dart';
import 'package:session1/models/employees.dart';
import 'package:session1/models/image_asset.dart';
import 'package:session1/models/locations.dart';

@immutable
abstract class AppEvent {}

//RESET
class DoResetASN extends AppEvent {}

//GET
class DoLoadDataAssetsList extends AppEvent {}

class DoLoadDataDropDow extends AppEvent {}

class DoLoadAssetSN extends AppEvent {
  final BigInt dID;
  final BigInt agID;

  DoLoadAssetSN(this.dID, this.agID);
}

class DoLoadLocation extends AppEvent {
  final BigInt dID;

  DoLoadLocation(this.dID);
}

class DoTransferHistory extends AppEvent{
  final BigInt aID;

  DoTransferHistory(this.aID);

}

//POST
class DoPostRegistering extends AppEvent {
  final Departments department;
  final Locations locations;
  final String asn;
  final String an;
  final Employees employees;
  final AssetsGroup assetsGroup;
  final String dsc;
  final String wd;
  final List<ImageAsset> listImg;

  DoPostRegistering(
      {this.department,
      this.locations,
      this.asn,
      this.an,
      this.employees,
      this.assetsGroup,
      this.dsc,
      this.wd,
      this.listImg});
}

class DoEditing extends AppEvent {
  final String an;
  final Employees employees;
  final String dsc;
  final String wd;
  final List<ImageAsset> listImg;
  final int oldListImgLength;
  final int index;

  DoEditing(this.an, this.employees, this.dsc, this.wd, this.listImg,
      this.oldListImgLength, this.index);
}

class DoTransfers extends AppEvent {
  final BigInt aID;
  final String asnNew;
  final String asnOld;
  final String dlIDOld;
  final Departments departments;
  final Locations locations;
  final String date;

  DoTransfers({this.aID, this.asnNew, this.asnOld, this.dlIDOld,
      this.departments, this.locations, this.date});
}
