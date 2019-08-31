<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body style="background:#a4bef2;">
    <?php
     require("masterpage.php");
     require ('sqlconnect.php');
     ?>
     <div id="links">

     </div>

     <script language="javascript" type="text/javascript">

     function autoRefresh_div() {
    $("#links").load("parking.php", function() {
        setTimeout(autoRefresh_div, 2000);
    });
}

autoRefresh_div();
     </script>
  </body>
</html>
