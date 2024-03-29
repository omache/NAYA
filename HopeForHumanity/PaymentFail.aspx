﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentFail.aspx.cs" Inherits="HopeForHumanity.PaymentFail" %>

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
    <title>Fail - Hope For Humanity</title>
    <link rel="shortcut icon" type="image/x-icon" href="favico.ico" />
    <!-- google fonts -->
    <link href='http://fonts.googleapis.com/css?family=Lato:400,300italic,300,700%7CPlayfair+Display:400,700italic%7CRoboto:300%7CMontserrat:400,700%7COpen+Sans:400,300%7CLibre+Baskerville:400,400italic' rel='stylesheet' type='text/css' />
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
    <!--[if lt IE 9]>
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <!--Header Section Start Here -->
            <header id="header">
                <div class="container">
                    <div class="row primary-header">
                        <a href="Default.aspx" class="col-xs-12 col-sm-2 brand" title="Welcome to Hope For Humanity">
                            <img src="assets/img/logo.png" alt="Hope For Humanity" /></a>
                        <div class="social-links col-xs-12 col-sm-10">
                            <a href="Volunteer.aspx" class="btn btn-default btn-volunteer">Become volunteer</a>
                            <div runat="server" id="divLinks">
                                <!--Loaded from codebehind-->
                            </div>
                        </div>
                    </div>
                </div>
                <div class="navbar navbar-default" role="navigation">
                    <div class="container">
                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                        </div>

                        <!--MainMenu -->
                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div id="divMainMenu" runat="server">
                            <!-- This part is autogenerated from backend code FillItems() -->
                        </div>
                        <!-- /.navbar-collapse -->
                        <!--MainMenu-->
                    </div>
                    <!-- /.container-fluid -->
                </div>

            </header>
            <!-- Header Section End Here -->
            <!-- site content -->
            <div id="main">
                <!-- Breadcrumb Section Start Here -->
                <div class="breadcrumb-section payment-breadcrumb-section">
                </div>
                <!-- Breadcrumb Section End Here -->

                <section class="container" id="page-info">
                    <div class="row">
                        <!-- Table Section Start Here -->
                        <div class="col-xs-12 payment-success-box">
                            <strong>Thank You</strong>
                            <div class="hand-pics">
                                <img src="assets/svg/heart-thanks.svg" alt="" class="svg" />
                                <img src="assets/img/hand.png" alt="" class="hand-shake" />
                            </div>
                            <header class="page-header">
                                <h2>The Server Encountered a problem while processing your transaction.</h2>
                                <p>
                                    We highly appreciate your initiative towards helping the less fortunate.
                                </p>
                                <p>
                                    The payment was not authorized successfully at the moment due to a server error or wrong details. Kindly, go through previous page to ensure that the entered information is correct.
                                </p>
                                <a class="btn btn-default btn-again" href="Default.aspx">TRY AGAIN</a>
                            </header>
                        </div>
                    </div>
                </section>
            </div>
            <!--Footer Section Start Here -->
            <footer id="footer">
                <div class="container" runat="server" id="divFooter">
                    <!--Generated From codebehind-->
                </div>
                <div class="copyright">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12">
                                <span>&copy; Copyright
                                    <script>document.write(new Date().getFullYear())</script>
                                    , All Rights Reserved by Hope For Humanity Foundation.
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
            <!--Footer Section End Here -->
        </div>

        <script src="assets/js/jquery.min.js"></script>
        <!-- Switcher Style Js -->
        <script src="assets/js/style-switcher/assets/js/style.switcher.js"></script>
        <script src="assets/js/jquery.cookie.js"></script>
        <!-- Switcher Style End Js -->
        <script src="assets/js/bootstrap.min.js"></script>
        <script src="assets/js/site.js"></script>
        <!--Custom Js validation & stuff-->
        <script src="assets/js/custom.js"></script>
        <script>
            // functions autocomplete
            var people = ['<a href="CauseDetails.aspx?Request=101200">Shelter</a><br/>',
                '<a href="CauseDetails.aspx?Request=101201">Educate Girls</a><br/>',
                '<a href="CauseDetails.aspx?Request=101202">Grow Food</a><br/>',
                '<a href="CauseDetails.aspx?Request=101203">Feed a child</a><br/>',
                '<a href="CauseDetails.aspx?Request=101204">Build Schools</a><br/>',
                '<a href="CauseDetails.aspx?Request=101205">Health Care</a><br/>',
                '<a href="Volunteer.aspx">Volunteer</a><br/>',
                '<a href="Ourstory.aspx">Our Story</a><br/>',
                '<a href="Ourmission.aspx">Our Story</a><br/>',
                '<a href="Ourstory.aspx">Our Mission</a><br/>',
                '<a href="Events.aspx">Events</a><br/>',
                '<a href="Blog.aspx">Blog</a><br/>'];

            function matchPeople(input) {
                var reg = new RegExp(input.split('').join('\\w*\\s*\\w*').replace(/\W/, ""), 'i');
                return people.filter(function (person) {
                    if (person.match(reg)) {
                        return person;
                    }
                });
            }

            function changeInput(val) {
                var test = '';
                var autoCompleteResult = matchPeople(val);
                if (val != '') {
                    for (i = 0; i < autoCompleteResult.length; i++) {
                        test += autoCompleteResult[i];
                    }
                    document.getElementById("result").innerHTML = test;
                }
                else
                    document.getElementById("result").innerHTML = '';
            }
        </script>
    </form>
</body>
</html>
