import 'dart:async';

import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:session1/bloc/app_state.dart';
import 'package:session1/bloc/app_event.dart';
import 'package:session1/helpers/provider_helper.dart';
import 'package:session1/models/assets_group.dart';
import 'package:session1/models/assets_list.dart';
import 'package:session1/models/departments.dart';
import 'package:session1/models/employees.dart';
import 'package:session1/models/locations.dart';
import 'package:session1/models/transfer_history.dart';

class AppBloc extends Bloc<AppEvent, AppState> {
  List<AssetsList> listAssets = [];
  List<AssetsList> listFilter = [];
  List<Departments> listDepartments = [];
  List<AssetsGroup> listAssetGroups = [];
  List<Locations> listLocations = [];
  List<Employees> listEmployees = [];
  List<TransferHistory> listTransferHistory = [];
  String asn = "dd/gg/nnnn";
  String rlPost = "";
  Completer completer = Completer();

  void dispose() {
    this.close();
  }

  @override
  AppState get initialState => LoadDataInitial();

  @override
  Stream<AppState> mapEventToState(AppEvent event) async* {
    //RESET
    if (event is DoResetASN) {
      yield LoadDataLoading();
      asn = "dd/gg/nnnn";
      yield LoadDataSuccess();
    }

    //GET
    if (event is DoLoadDataAssetsList) {
      yield LoadDataLoading();
      listAssets = await ProviderHelper.getAssetsList();
      listFilter = listAssets;
      yield LoadDataSuccess();
    }

    if (event is DoLoadDataDropDow) {
      yield LoadDataLoading();
      listDepartments = await ProviderHelper.getDepartmentList();
      listAssetGroups = await ProviderHelper.getAssetGroupList();
      listEmployees = await ProviderHelper.getEmployeeList();
      yield LoadDataSuccess();
    }

    if (event is DoLoadLocation) {
      yield LoadDataLoading();
      listLocations = await ProviderHelper.getLocationList(event.dID);
      yield LoadDataSuccess();
    }

    if (event is DoLoadAssetSN) {
      yield LoadDataLoading();
      asn = await ProviderHelper.getASN(event.dID, event.agID);
      yield LoadDataSuccess();
    }

    if(event is DoTransferHistory){
      yield LoadDataLoading();
      listTransferHistory = await ProviderHelper.getTransferHistory(event.aID);
      yield LoadDataSuccess();
    }

    //POST
    if (event is DoPostRegistering) {
      yield Posting();
      if (event.department == null ||
          event.locations == null ||
          event.an == null ||
          event.employees == null ||
          event.assetsGroup == null ||
          event.dsc == null) {
        //
        yield PostErrorValidateAll();
      } else {
        //
        bool isDuplicateData = false;
        for (int i = 0; i < listAssets.length; i++) {
          if (event.an.toLowerCase().contains(listAssets[i].an.toLowerCase()) &&
              event.locations.name
                  .toLowerCase()
                  .contains(listAssets[i].ln.toLowerCase())) {
            //
            isDuplicateData = true;
            break;
          }
        }
        if (isDuplicateData) {
          //
          yield PostErrorDuplicateData();
        } else {
          //
          String query;
          if (event.wd == "") {
            query =
                "INSERT INTO assets VALUES (null, '${event.asn}', '${event.an}', (SELECT ID FROM departmentlocations WHERE DepartmentID = ${event.department.id} AND LocationID = ${event.locations.id} LIMIT 1), ${event.employees.id}, ${event.assetsGroup.id}, '${event.dsc}', null)";
          } else {
            query =
                "INSERT INTO assets VALUES (null, '${event.asn}', '${event.an}', (SELECT ID FROM departmentlocations WHERE DepartmentID = ${event.department.id} AND LocationID = ${event.locations.id} LIMIT 1), ${event.employees.id}, ${event.assetsGroup.id}, '${event.dsc}', '${event.wd}')";
          }

          rlPost = await ProviderHelper.post(query);

          bool isSuccess = true;
          if (rlPost.contains('success') && event.listImg.length > 0) {
            //
            for (int i = 0; i < event.listImg.length; i++) {
              query =
                  "INSERT INTO assetphotos VALUES (null,(SELECT ID FROM assets ORDER BY ID DESC LIMIT 1),'${event.listImg[i].img}')";
              rlPost = await ProviderHelper.post(query);
              if (rlPost.contains('error')) {
                isSuccess = false;
              }
            }
          }

          yield isSuccess ? PostSuccess() : PostError();
        }
      }
    }

    if (event is DoEditing) {
      yield Posting();
      bool isDuplicateData = false;
      if (!event.an
          .toUpperCase()
          .contains(listAssets[event.index].an.toUpperCase())) {
        //
        for (int i = 0; i < listAssets.length; i++) {
          if (event.an.toUpperCase().contains(listAssets[i].an.toUpperCase()) &&
              listAssets[event.index]
                  .ln
                  .toUpperCase()
                  .contains(listAssets[i].ln.toUpperCase())) {
            //
            isDuplicateData = true;
            break;
          }
        }
      }

      if (isDuplicateData) {
        yield PostErrorDuplicateData();
      } else {
        //
        String query;
        BigInt eID = event.employees != null
            ? event.employees.id
            : listAssets[event.index].eID;
        if (event.wd == '') {
          query =
              "UPDATE assets SET AssetName = '${event.an}', EmployeeID = '$eID', Description = '${event.dsc}', WarrantyDate = null  WHERE ID = ${listAssets[event.index].id}";
        } else {
          query =
              "UPDATE assets SET AssetName = '${event.an}', EmployeeID = '$eID', Description = '${event.dsc}', WarrantyDate = '${event.wd}'  WHERE ID = ${listAssets[event.index].id}";
        }
        rlPost = await ProviderHelper.post(query);
        //
        bool isSuccess = true;
        int currentListImgLength = event.listImg.length;
        if (currentListImgLength > event.oldListImgLength) {
          //
          for (int i = event.oldListImgLength; i < event.listImg.length; i++) {
            query =
                "INSERT INTO assetphotos VALUES (null,${listAssets[event.index].id},'${event.listImg[i].img}')";
            rlPost = await ProviderHelper.post(query);
            if (rlPost.contains('error')) {
              isSuccess = false;
            }
          }
        }
        yield isSuccess ? PostSuccess() : PostError();
      }
    }

    if (event is DoTransfers) {
      yield Posting();
      if (event.departments == null || event.locations == null) {
        yield PostErrorValidateAll();
      } else {
        //
        String query;
        query =
            "UPDATE assets SET AssetSN = '${event.asnNew}', DepartmentLocationID = (SELECT ID FROM departmentlocations WHERE DepartmentID = ${event.departments.id} AND LocationID = ${event.locations.id} LIMIT 1) WHERE ID = ${event.aID}";
        rlPost = await ProviderHelper.post(query);
        bool isSuccess = true;
        if (rlPost.contains('success')) {
          query =
              "INSERT INTO assettransferlogs VALUES(null, ${event.aID}, '${event.date}', '${event.asnOld}', '${event.asnNew}', ${event.dlIDOld}, (SELECT ID FROM departmentlocations WHERE DepartmentID = ${event.departments.id} AND LocationID = ${event.locations.id} LIMIT 1))";
          rlPost = await ProviderHelper.post(query);
          if(rlPost.contains('error')){
            isSuccess = false;
          }
        }
        yield isSuccess? PostSuccess() : PostError();
      }
    }
  }
}
