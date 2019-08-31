<?php
// $mysqli = new mysqli("johnny.heliohost.org", "parking1_parking", "parking", "parking1_parking");
// if (mysqli_connect_errno()) {
// printf("Connect failed: %s\n", mysqli_connect_error()); //this will print out the error while connecting to MySQL, if any
// exit();
// }
$host = "johnny.heliohost.org";
$username = "kunz398_parking";
$password = "kunal123";
$db = "kunz398_parking1_parking";



// Create connection
$conn = new mysqli($host, $username, $password, $db);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

/*DBname:u145310258_droid
User:u145310258_droid
Host:mysql.hostinger.in
Password:droid123*/
      //$con = mysqli_connect("johnny.heliohost.org", "parking1_parking", "parking", "parking1_parking");
 /*JSON ARRAY
       $response = array();

   $sql_city = "SELECT * FROM parkinglot ";
     $result = $con->query($sql_city);
     if ($result->num_rows > 0)
     { //checks if city exists (in db)
        while($row = $result->fetch_assoc())
           {
               $response['result'] []=
               [
                   'success' => true,
                   'location' => $row["location"],
                   'parked' => $row["parked"]
               ];
           }//while end
     }

  echo json_encode($response,JSON_UNESCAPED_SLASHES);

  */

?>
