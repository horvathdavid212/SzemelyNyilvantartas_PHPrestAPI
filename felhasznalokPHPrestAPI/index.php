<?php


include("connection.php");
$db = new dbObj(); $connection =  $db->getConnstring();
$request_method=$_SERVER["REQUEST_METHOD"];

switch($request_method) {

  case 'GET':
    get_felhasznalok(); break;
    
  case 'POST':
    insert_felhasznalok();  break;

  case 'PUT':
   $id=intval($_GET["id"]);
   update_felhasznalok($id);
   break;

  case 'DELETE':
   $id=intval($_GET["id"]);
   delete_felhasznalok($id);
   break;

  default:
  header("HTTP/1.1 405 Method Not Allowed"); break;
}

function get_felhasznalok(){

  global $connection;
  $query="SELECT * FROM felhasznalok";
  $response=array();
  $result=mysqli_query($connection, $query);
  while($row=mysqli_fetch_array($result))
  {
    $response[]=$row;
  }

  header('Content-Type: application/json'); //send the header
  echo json_encode($response); //data in JSON format
}

function insert_felhasznalok()  {

  global $connection;
  $data = json_decode(file_get_contents('php://input'), true);        
  $vezeteknev=$data["vezeteknev"];
  $keresztnev=$data["keresztnev"];
  $eletkor=$data["eletkor"];
  $lakhely=$data["lakhely"];
  echo $query="INSERT INTO felhasznalok SET vezeteknev='".$vezeteknev."', keresztnev='".$keresztnev."', eletkor='".$eletkor."', lakhely='".$lakhely."'";

  if(mysqli_query($connection, $query)){
    $response=array(
          'status' => 1,
          'status_message' =>'Felhasznalo sikeresen inzertálva.'
            );
  }else{
    $response=array(
          'status' => 0,
          'status_message' =>'Felhasznalo inzertálása sikertelen.'
          );
  }   

  header('Content-Type: application/json');
  echo json_encode($response);
 }


function update_felhasznalok($id) {
  global $connection;
  $data = json_decode(file_get_contents('php://input'), true);
  $vezeteknev=$data["vezeteknev"];
  $keresztnev=$data["keresztnev"];
  $eletkor=$data["eletkor"];
  $lakhely=$data["lakhely"];

  echo $query="UPDATE felhasznalok SET vezeteknev='".$vezeteknev."', keresztnev='".$keresztnev."', eletkor='".$eletkor."', lakhely='".$lakhely."' WHERE id=".$id;

  if(mysqli_query($connection, $query)){

    $response=array(
          'status' => 1,
          'status_message' =>'Felhasznalo sikeresen frissült.'
           );
  }else{
    $response=array(

          'status' => 0,
          'status_message' =>'Felhasznalo nem frissült. Hiba!'
          );
  }   

 header('Content-Type: application/json');

 echo json_encode($response); //response with header
}



function delete_felhasznalok($id) {

  global $connection;
  $query="DELETE FROM felhasznalok WHERE id=".$id;
  if(mysqli_query($connection, $query)){
    $response=array(
          'status' => 1,
          'status_message' =>'Felhasznalo törlése megtörtént.'
           );
  }else{
    $response=array(

          'status' => 0,
          'status_message' =>'Felhasznalo törlése sikertelen.'
          );
  } 

   header('Content-Type: application/json');

   echo json_encode($response);

}