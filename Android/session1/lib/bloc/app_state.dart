import 'package:flutter/cupertino.dart';

@immutable
abstract class AppState {}

//GET
class LoadDataInitial extends AppState {}

class LoadDataLoading extends AppState {}

class LoadDataSuccess extends AppState {}

class LoadDataError extends AppState {
  final String errMessage;

  LoadDataError({this.errMessage});
}

//POST
class Posting extends AppState{}

class PostSuccess extends AppState{}

class PostErrorValidateAll extends AppState{}

class PostErrorDuplicateData extends AppState{}

class PostError extends AppState{}