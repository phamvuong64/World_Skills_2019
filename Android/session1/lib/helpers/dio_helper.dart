import 'package:dio/dio.dart';

class DioHelper{
  static Dio dio = Dio();
  static Future<dynamic> get(String url) async{
    try{
      final rl = await dio.get(url);
      print("GetDataSuccess");
      return rl.data;
    }catch(e){
      print('GetDataERROR');
      return e.toString();
    }
  }


  static Future<dynamic> postForm(String url, FormData formData) async {
    try{

      final rl = await dio.post(url, data: formData);

      print(rl);
      return rl.toString();
    }catch(e){
      return e.toString();
    }

  }
}