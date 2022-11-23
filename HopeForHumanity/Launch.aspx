<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Launch.aspx.cs" Inherits="HopeForHumanity.Launch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="assets/js/gtag.js"></script>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />
    <meta name="keywords" content="African Children, Orphans, Donate, Donation, Charity, Shelter, Rehabilitation" />
    <!--Search engine optimization-->
    <meta name="description" content="Hope for humanity is a foundation that provides help to people in need, feeding and nurturing african children, orphans. Charity website. Donate to african children. Free slaves Libya" />
    <meta name="robots" content="index,follow" />
    <meta name="DC.title" content="Hope For Humanity Charity Website" />
    <title>Launch - Hope For Humanity</title>
    <link rel="shortcut icon" type="image/x-icon" href="favico.ico" />
    <!-- google fonts -->
    <link href='http://fonts.googleapis.com/css?family=Lato:400,300italic,300,700' rel='stylesheet' type='text/css' />
    <!-- Bootstrap -->
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
    <link href="assets/revolution-slider/css/settings.css" rel="stylesheet" />
    <link href="assets/css/global.css" rel="stylesheet" />
    <link href="assets/css/style.css" rel="stylesheet" />
    <link href="assets/css/responsive.css" rel="stylesheet" />
    <link href="assets/css/skin.css" rel="stylesheet" />
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper" class=" launch clearfix">
            <header id="header">
                <div class="container">
                    <div class="row">
                        <a href="Default.aspx" class="col-xs-12" title="Welcome to Hope for Humanity">
                            <img src="assets/img/logo.png" alt="Hope For Humanity" /></a>
                    </div>
                </div>
            </header>
            <div class="content">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12 col-md-7 col-lg-5">
                            <h1>Big things are coming in 2018</h1>
                            <span class="stay">Stay tuned with us for the surprise and feel free to leave an email to know our latest updates </span>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-7 col-lg-6">
                            <!-- CountDown Frame -->
                            <div id="defaultCountdown" class="counter clearfix"></div>
                            <!-- CountDown Frame -->
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 col-md-7 col-lg-6">
                            <div class="input-group">
                                <input class="form-control" type="email" placeholder="Enter email address" />
                                <div class="input-group-addon">
                                    <input type="submit" class="btn btn-theme" value="submit" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <footer id="footer">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 col-xs-12">
                            <span>&copy; Copyright
                                <script>document.write(new Date().getFullYear())</script>
                                , All Rights Reserved by Hope For Humanity Foundation.</span>
                        </div>
                    </div>
                </div>
            </footer>
        </div>

        <script src="assets/js/jquery.min.js"></script>
        <!-- Bootstrap Js-->
        <script src="assets/js/bootstrap.min.js"></script>
        <script src="assets/js/jquery.easing.min.js"></script>
        <!--countdown Js-->
        <script src="assets/js/jquery.plugin.js"></script>
        <script src="assets/js/jquery.countdown.js"></script>
        <!--countdown Js End -->
        <!-- 	<script src="assets/js/site.js"></script><!--Custom Js validation & stuff--><script src="assets/js/custom.js"></script> -->
        <script>
            $(function () {
                $("#defaultCountdown").countdown({
                    //Time set = Year, Month,Date
                    until: new Date(2018, 2, 14)
                });

            });
		</script>
    </form>
</body>
</html>
