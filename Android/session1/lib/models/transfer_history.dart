class TransferHistory extends Object {
  String date;
  String fromDepName;
  String fromAssetSN;
  String toDepName;
  String toAssetSN;

  TransferHistory(
      {this.date,
      this.fromDepName,
      this.fromAssetSN,
      this.toDepName,
      this.toAssetSN});

  factory TransferHistory.formJson(dynamic json) {
    return TransferHistory(
      date: json['date'],
      fromDepName: json['fromDepName'],
      fromAssetSN: json['fromAssetSN'],
      toDepName: json['toDepName'],
      toAssetSN: json['toAssetSN'],
    );
  }
}
