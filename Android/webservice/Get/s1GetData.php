<?php
    $connect = mysqli_connect("localhost","root","Vuong1999","session1");

    /*ListData*/
    $arrayListData = array();
    $query1 = "SELECT a.ID, a.EmployeeID, CONCAT(e.FirstName, ' ' , e.LastName) AS eName, a.AssetGroupID AS agID, ag.Name AS AG, l.Name AS LN, a.AssetName, d.Name AS DN, a.AssetSN, a.Description, a.DepartmentLocationID, a.WarrantyDate, (SELECT ap.AssetPhoto FROM assetphotos ap WHERE a.ID = ap.AssetID LIMIT 1) AS AP FROM assets a JOIN departmentlocations dl ON a.DepartmentLocationID = dl.ID JOIN departments d ON dl.DepartmentID = d.ID JOIN assetgroups ag ON ag.ID = a.AssetGroupID JOIN locations l ON l.ID = dl.LocationID JOIN employees e ON a.EmployeeID = e.ID ORDER BY a.ID";
    $data1 = mysqli_query($connect, $query1);
    while ($row = mysqli_fetch_assoc($data1)){

        array_push($arrayListData, new ListData($row['ID'], $row['EmployeeID'], $row['eName'], $row['agID'], $row['AG'],$row['LN'] , $row['AssetName'], $row['DN'], $row['AssetSN'],$row['Description'], $row['DepartmentLocationID'], $row['WarrantyDate'], $row['AP']));
    }

    /*Assetgroups*/
    $arrAssetgroups = array();
    $query2 = "SELECT * FROM assetgroups";
    $data2 = mysqli_query($connect, $query2);
    while ($row = mysqli_fetch_assoc($data2)){
        array_push($arrAssetgroups,new getAssetGroup($row['ID'], $row['Name']));
    }

    /*Employee*/
    $arrayEmployee = array();
    $query3 = "SELECT ID, CONCAT(FirstName, ' ' , LastName) AS Name FROM employees";
    $data3 = mysqli_query($connect, $query3);
    while ($row = mysqli_fetch_assoc($data3)) {
        
        array_push($arrayEmployee, new Employee($row['ID'], $row['Name']));
    }

    /*Location*/
    $arrLocation = array();
    if(isset($_GET['dID'])){

        $dID = $_GET['dID'];
        $query4 = "SELECT l.ID, l.Name FROM departmentlocations dl JOIN locations l ON dl.LocationID = l.ID WHERE DepartmentID = $dID";
        $data4 = mysqli_query($connect, $query4);
        while ($row = mysqli_fetch_assoc($data4)){
            array_push($arrLocation,new getLocation($row['ID'], $row['Name']));
        }

    }
    
    /*Department*/
    $arrDepartment = array();
    $query5 = "SELECT * FROM departments";
    $data5 = mysqli_query($connect, $query5);
    while ($row = mysqli_fetch_assoc($data5)){
        array_push($arrDepartment, new getDepartment($row['ID'], $row['Name']));
    }

    $asn = array();
    if(isset($_GET['dID'], $_GET['agID'])){

        $dID = $_GET['dID'];
        $agID = $_GET['agID'];

        $query = "SELECT a.AssetSN FROM assets a JOIN departmentlocations dl ON a.DepartmentLocationID = dl.ID JOIN departments d ON dl.DepartmentID = d.ID WHERE d.ID = $dID AND a.AssetGroupID = $agID ORDER BY a.ID DESC LIMIT 1 ";

        $data = mysqli_query($connect, $query);
            
        while ($row = mysqli_fetch_assoc($data)){
            array_push($asn, $row['AssetSN']);
        }
    }

    $atl = array();
    if(isset($_GET['aID'])){
        $aID = $_GET['aID'];

        $query = "SELECT atl.TransferDate, d1.Name AS FromDepName, atl.FromAssetSN, d2.Name AS ToDepName, atl.ToAssetSN from assettransferlogs atl JOIN departmentlocations dl1 ON atl.FromDepartmentLocationID = dl1.ID JOIN departments d1 ON dl1.DepartmentID = d1.ID JOIN departmentlocations dl2 ON atl.ToDepartmentLocationID = dl2.ID JOIN departments d2 ON dl2.DepartmentID = d2.ID WHERE atl.AssetID = $aID AND DATEDIFF(CURRENT_DATE ,TransferDate) <=365";
        $data = mysqli_query($connect, $query);
        while ($row = mysqli_fetch_assoc($data)) {
            array_push($atl, new getTransferlog($row['TransferDate'], $row['FromDepName'], $row['FromAssetSN'], $row['ToDepName'], $row['ToAssetSN']));
        }


    }

    $arr = array(
        "listData"      =>$arrayListData,
        "assetGroups"   =>$arrAssetgroups,
        "employee"      =>$arrayEmployee,
        "location"      =>$arrLocation,
        "department"    =>$arrDepartment,
        "asn"           =>$asn,
        "log"           =>$atl,
    );

    echo json_encode($arr);

    class ListData{
    	function ListData($id, $employeeID, $eName, $agID, $agn, $ln, $an, $dn, $asn, $des, $dlID, $wd, $ap){
            $this-> id = $id;
            $this-> eID = $employeeID;
            $this-> eName = $eName;
            $this-> agID = $agID;
            $this-> agn = $agn;
            $this-> ln = $ln;
    		$this-> an = $an;
    		$this-> dn = $dn;
    		$this-> asn = $asn;
            $this-> des = $des;
            $this-> dlID = $dlID;
            $this-> wd = $wd;
            $this-> ap = $ap;

    	}
    }

    class getAssetGroup{
        function getAssetGroup($id, $name){
            $this-> id = $id;
            $this-> name = $name;
        }
    }

    class Employee {
        
        function Employee($id, $fullName)
        {
            $this-> id = $id;
            $this-> fullName =$fullName;
        }
    }

    class getLocation{
        function getLocation($id, $name){
            $this-> id = $id;
            $this-> name = $name;
        }
    }

    class getDepartment{
        function getDepartment($id, $name){
            $this-> id = $id;
            $this-> name = $name;
        }
    }

    /**
     * 
     */
    class getTransferlog{
        
        function getTransferlog($date, $FromDepName, $FromAssetSN, $ToDepName, $ToAssetSN )
        {
            $this-> date = $date;
            $this-> fromDepName = $FromDepName;
            $this-> fromAssetSN = $FromAssetSN;
            $this-> toDepName = $ToDepName;
            $this-> toAssetSN = $ToAssetSN;

        }
    }


?>