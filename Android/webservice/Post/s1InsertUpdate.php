<?php
	$connect = mysqli_connect("localhost", "root","Vuong1999", "session1");
	
	// $string_query = $_POST['query'];
	if(isset($_POST['query'])){

		
		$str_query = $_POST['query'];
		$query = $str_query;


		if(mysqli_query($connect, $query)){

			echo '"success"';

		}else{
		
			echo '"error"';
		}
	}


?>