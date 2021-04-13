class Locations extends Object{
  BigInt id;
  String name;

  Locations({this.id, this.name});

  factory Locations.fromJson(dynamic json){
    return Locations(
      id : BigInt.parse(json['id']),
      name : json['name']
    );
  }
}