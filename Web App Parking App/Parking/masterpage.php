
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="shortcut icon" href="images/icon.ico" />
  <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title></title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/customestyle.css" rel="stylesheet">

   <link rel="stylesheet" type="text/css" href="css/fontawesome/css/font-awesome.min.css" />
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
  <!-- <div style="background-color: #272525;" class="navbar-default navbar-fixed-top1" id="navscroll" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar" ></span>
                        <span class="icon-bar" ></span>
                        <span class="icon-bar" ></span>
                     </button>
                    <a class="navbar-brand" href="Default.aspx"><span><img alt="logo" src="images/logo.png" height="30" /></span>NAME OF WEBSITE</a>

                  </div>
                 <div class="navbar-collapse collapse">

                 <ul id="navbar" class="nav navbar-nav navbar-right">
                    <li class="active"><a href="#"><i class="fa fa-home"> Home</i></a></li>
                     <li class="dropdown">
                        <a href="#"  class="dropdown-toggle" data-toggle="dropdown">MenuBar2<b class="caret"></b></a>
                        <ul style="background-color:black;" class="dropdown-menu">
                            <li class="dropdown-header">dropdownheading</li>
                             <li><a href="#">dropdown1</a></li>
                              <li><a href="#">dropdown2</a></li>
                        </ul>
                    </li>
                    <li><a href="#">MenuBar2</a></li>
                    <li><a href="#">MenuBar3</a></li>
                    <li><a href="#">MenuBar4</a></li>
                 </ul>
                 </div>
          </div>
      </div> -->






  <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <!--My custom Jquery for pages to be highlited -->
    <script type="text/javascript">
        $(document).ready(function () {
            // -----------------------------------------------------------------------
            $.each($('#navbar').find('li'), function () {
                $(this).toggleClass('active',
                    window.location.pathname.indexOf($(this).find('a').attr('href')) > -1);
            });
            // -----------------------------------------------------------------------
        });
    </script>
  </body>
  </html>
