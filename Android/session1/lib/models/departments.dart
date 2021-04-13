class Departments extends Object{
  BigInt id;
  String name;

  Departments({this.id, this.name});
  
  factory Departments.fromJson(dynamic json){
    return Departments(
      id: BigInt.parse(json['id']),
      name: json['name']
    );
  }
}