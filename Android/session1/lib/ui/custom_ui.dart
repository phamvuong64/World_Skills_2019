import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
class CustomUi{
  static customAppBar(BuildContext context, String name){
    return PreferredSize(
      preferredSize: Size.fromHeight(MediaQuery.of(context).size.height * 0.07),
      child: Container(
        alignment: Alignment.center,
        color: Colors.blue,
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: <Widget>[
            Text(
              name,
              style: TextStyle(
                color: Colors.white,
                fontWeight: FontWeight.bold,
              ),
            ),
            InkWell(
              child: Text(
                'Back',
                style: TextStyle(
                  color: Colors.amberAccent,
                ),
              ),
              onTap: (){
                Navigator.pop(context);
              },
            ),
          ],
        ),
      ),
    );
  }
}



