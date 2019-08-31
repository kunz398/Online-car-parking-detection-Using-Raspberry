<?php
// $mysqli = new mysqli("johnny.heliohost.org", "parking1_parking", "parking", "parking1_parking");
// if (mysqli_connect_errno()) {
// printf("Connect failed: %s\n", mysqli_connect_error()); //this will print out the error while connecting to MySQL, if any
// exit();
// }
$host = "johnny.heliohost.org";
$username = "ENTER USER NAME";
$password = "ENTER PASS";
$db = "ENTER DB NAME";



// Create connection
$conn = new mysqli($host, $username, $password, $db);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}



?>
