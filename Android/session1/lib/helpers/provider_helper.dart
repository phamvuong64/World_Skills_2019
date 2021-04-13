import 'dart:convert';

import 'package:dio/dio.dart';
import 'package:session1/constants/api_url.dart';
import 'package:session1/helpers/dio_helper.dart';
import 'package:session1/models/assets_group.dart';
import 'package:session1/models/assets_list.dart';
import 'package:session1/models/departments.dart';
import 'package:session1/models/employees.dart';
import 'package:session1/models/locations.dart';
import 'package:session1/models/transfer_history.dart';

class ProviderHelper {
  //GET
  static Future<List<AssetsList>> getAssetsList() async {
    var jsonData = await DioHelper.get(ApiURL.GET);

    var assetsList = json.decode(jsonData)['listData'] as List<dynamic>;

    List<AssetsList> list = assetsList
        .map<AssetsList>((item) => AssetsList.fromJson(item))
        .toList();

    return list;
  }

  static Future<List<Departments>> getDepartmentList() async {
    var jsonData = await DioHelper.get(ApiURL.GET);

    var dn = json.decode(jsonData)['department'] as List<dynamic>;
    List<Departments> list =
        dn.map<Departments>((item) => Departments.fromJson(item)).toList();
    return list;
  }

  static Future<List<AssetsGroup>> getAssetGroupList() async {
    var jsonData = await DioHelper.get(ApiURL.GET);

    var ag = jsonDecode(jsonData)['assetGroups'] as List<dynamic>;

    List<AssetsGroup> list =
        ag.map<AssetsGroup>((e) => AssetsGroup.fromJson(e)).toList();
    return list;
  }

  static Future<List<Locations>> getLocationList(BigInt dID) async {
    var jsonData = await DioHelper.get(ApiURL.GET + "?dID=$dID");

    var l = jsonDecode(jsonData)['location'] as List<dynamic>;

    List<Locations> list =
        l.map<Locations>((e) => Locations.fromJson(e)).toList();
    return list;
  }

  static Future<List<Employees>> getEmployeeList() async {
    var jsonData = await DioHelper.get(ApiURL.GET);

    var em = jsonDecode(jsonData)['employee'] as List<dynamic>;

    List<Employees> list =
        em.map<Employees>((e) => Employees.fromJson(e)).toList();
    return list;
  }

  static Future<String> getASN(BigInt dID, BigInt agID) async {
    var jsonData = await DioHelper.get(ApiURL.GET + "?dID=$dID&agID=$agID");
    var rl = jsonDecode(jsonData)['asn'] as List<dynamic>;
    String nnnn;
    if (rl.length == 0) {
      nnnn = '0001';
    } else {
      int x = int.parse(rl[0].toString().substring(6)) + 1;

      nnnn = x >= 1000 ? '$x' : x >= 100 ? '0$x' : x >= 10 ? '00$x' : '000$x';
    }
    String dd = dID < (BigInt.parse('10')) ? '0$dID' : '$dID';
    String gg = agID < (BigInt.parse('10')) ? '0$agID' : '$agID';
    String asn = dd + '/' + gg + '/' + nnnn;
    return asn;
  }

  static Future<List<TransferHistory>> getTransferHistory(BigInt aID) async {
    var jsonData = await DioHelper.get(ApiURL.GET + "?aID=$aID");
    var th = jsonDecode(jsonData)['log'] as List<dynamic>;

    List<TransferHistory> list =
        th.map<TransferHistory>((e) => TransferHistory.formJson(e)).toList();
    return list;
  }

  //POST
  static Future<String> post(String query) async {
    FormData formData = new FormData.fromMap({
      "query": "$query",
    });

    var jsonData = await DioHelper.postForm(ApiURL.POST, formData);
    var rl = jsonDecode(jsonData);
    print('POST: ${rl.toString()}');
    return rl.toString();
  }
}
