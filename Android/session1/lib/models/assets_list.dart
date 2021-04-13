class AssetsList extends Object {
  BigInt id;
  BigInt eID;
  String eName;
  BigInt agID;
  String agn;
  String ln;
  String an;
  String dn;
  String asn;
  String des;
  String dlID;
  DateTime wd;
  String ap;

  AssetsList({this.id,
    this.eID,
    this.eName,
    this.agID,
    this.agn,
    this.ln,
    this.an,
    this.dn,
    this.asn,
    this.des,
    this.dlID,
    this.wd,
    this.ap});

  factory AssetsList.fromJson(Map<String, dynamic> json) {
    return AssetsList(
        id: BigInt.parse(json['id']),
        eID: BigInt.parse(json['eID']),
        eName: json['eName'],
        agID: BigInt.parse(json['agID']),
        agn: json['agn'],
        ln: json['ln'],
        an: json['an'],
        dn: json['dn'],
        asn: json['asn'],
        des: json['des'],
        dlID: json['dlID'],
        wd: json['wd'] == null ? null : DateTime.parse(json['wd']),
        ap: json['ap'] ?? "");
  }
}

