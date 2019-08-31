<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body >
    <?php
     require("masterpage.php");
    require ('sqlconnect.php');
     ?>
<div class="container"style="background: black; width: 500px; height: 500px;">

        <div id="A1" style="width: 35%; height: 14%; float: right; margin-top: 5%; margin-left: 33%;">
          A1
        </div>

        <div id="A2" style="width: 35%; height: 14%; float: right; margin-top: 3%; margin-left: 33%;">
          A2
        </div>

        <div id="B3" style=" width: 18%; height: 29%; margin-top: 73%; ">
          B3
        </div>

        <div id="B2" style=" width: 18%; height: 29% ;margin-top: -31% ;margin-left: 24%; ">
          B2
        </div>


        <div id="B1" style=" width: 18%; height: 29%; margin-top: -31%; margin-left: 49%;">
          B1
        </div>

     </div>

     <?php

        $sql = "SELECT * FROM parkinglot ";
        $result = $conn->query($sql);

        if ($result->num_rows > 0)
        {
           while($row = $result->fetch_assoc())
           {
              $location = $row['location'];
              $parked = $row['parked'];
              if ($parked == 1)
              {
                    echo "<script>$('#$location').css('background', 'red')</script>";
              }else {
                    echo "<script>$('#$location').css('background', 'blue')</script>";
              }
           }
       }

      ?>
  </body>
</html>
