import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:session1/bloc/app_bloc.dart';
import 'package:session1/bloc/app_event.dart';

class TransferHistoryScreen extends StatefulWidget {
  final AppBloc appBloc;
  final BigInt aID;

  TransferHistoryScreen({this.appBloc, this.aID});

  @override
  State<StatefulWidget> createState() => TransferHistoryScreenState();
}

class TransferHistoryScreenState extends State<TransferHistoryScreen> {
  final _globalKey = new GlobalKey<ScaffoldState>();

  @override
  void initState() {
    widget.appBloc.add(DoTransferHistory(widget.aID));
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Scaffold(
        body: SingleChildScrollView(
          child: Container(
            height: MediaQuery.of(context).size.height * 0.96,
            padding: EdgeInsets.all(10.0),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: <Widget>[
                Row(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: <Widget>[
                    Text('Transfer History',style: TextStyle(fontWeight: FontWeight.bold),),
                  ],
                ),
                BlocBuilder(
                  bloc: widget.appBloc,
                  builder: (context, state){
                    if (widget.appBloc.listTransferHistory.length == 0) {
                      return Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        crossAxisAlignment: CrossAxisAlignment.center,
                        children: <Widget>[
                          Text(
                            'There are no recent transfers in the last twelve months',
                          ),
                          Text('Please return Main Screen.')
                        ],
                      );
                    }
                    return Expanded(
                      child: ListView.builder(
                        itemCount: widget.appBloc.listTransferHistory.length,
                        itemBuilder: (context, index) {
                          return Card(
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.start,
                              crossAxisAlignment: CrossAxisAlignment.center,
                              children: <Widget>[
                                IconButton(
                                  icon: Icon(Icons.near_me),
                                ),
                                Column(
                                  mainAxisAlignment: MainAxisAlignment.center,
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: <Widget>[
                                    Text(
                                        'Relocation Date: ${widget.appBloc.listTransferHistory[index].date}'),
                                    Row(
                                      mainAxisAlignment: MainAxisAlignment.start,
                                      children: <Widget>[
                                        Text(widget
                                            .appBloc
                                            .listTransferHistory[index]
                                            .fromDepName +
                                            '  '),
                                        Text(
                                          widget
                                              .appBloc
                                              .listTransferHistory[index]
                                              .fromAssetSN,
                                          style: TextStyle(
                                            color: Colors.red,
                                          ),
                                        ),
                                      ],
                                    ),
                                    Row(
                                      mainAxisAlignment: MainAxisAlignment.start,
                                      children: <Widget>[
                                        Text(widget
                                            .appBloc
                                            .listTransferHistory[index]
                                            .toDepName +
                                            '  '),
                                        Text(
                                          widget
                                              .appBloc
                                              .listTransferHistory[index]
                                              .toAssetSN,
                                          style: TextStyle(
                                            color: Colors.red,
                                          ),
                                        ),
                                      ],
                                    ),
                                  ],
                                )
                              ],
                            ),
                          );
                        },
                      ),
                    );
                  },
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.end,
                  children: <Widget>[
                    SizedBox(
                      width: 150,
                      child: RaisedButton(
                        child: Text('Back'),
                        onPressed: (){
                          Navigator.pop(context);
                        },
                      ),
                    )
                  ],
                )
              ],
            ),
          ),
        ),
      ),
    );
  }
}
