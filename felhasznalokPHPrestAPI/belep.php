<?php


#include("connection.php");
#$db = new dbObj(); $connection =  $db->getConnstring();

$con = mysqli_connect("localhost", "root", "", "nyilvantartasdb");
if(!$con){
  die("noconnect to database");
}

$user_usernamee="";
$user_passwordd="";

if(isset($_POST['felhasznalonev']) && !empty($_POST['felhasznalonev']) && isset($_POST['jelszo']) && !empty($_POST['jelszo'])){
  $user_usernamee = mysqli_real_escape_string($con, $_POST['felhasznalonev']);
  $user_passwordd = mysqli_real_escape_string($con, $_POST['jelszo']);
}else{
  die("nodata");
}

$query_login = $con->Query("SELECT user_username FROM users WHERE user_username= '".$user_usernamee."' LIMIT 1");
if(!$query_login){
  die("dataerror");
}
elseif($query_login->num_rows !=1){
  die("usernotfound");
}
else{
  
  $sql = "SELECT * FROM users WHERE user_username = '$user_usernamee' AND user_password = '$user_passwordd'";
  $result = mysqli_query($con, $sql);

  if (mysqli_num_rows($result) > 0) {
      die("siker");
  } else {
      die("userwrongpass");
  }
}






