class AssetsGroup extends Object{
  BigInt id;
  String name;

  AssetsGroup({this.id, this.name});

  factory AssetsGroup.fromJson(dynamic json){
    return AssetsGroup(
        id: BigInt.parse(json['id']),
        name: json['name']
    );
  }
}