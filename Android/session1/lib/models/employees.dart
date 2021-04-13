class Employees extends Object {
  BigInt id;
  String fullName;


  Employees({this.id, this.fullName});

  factory Employees.fromJson(dynamic json) {
    return Employees(id: BigInt.parse(json['id']), fullName: json['fullName']);
  }
}
