﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Volunteer.aspx.cs" Inherits="HopeForHumanity.Volunteer" %>

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
    <title>Volunteer - Hope For Humanity</title>
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
                <div class="breadcrumb-section">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12">
                                <h1>Become A Volunteer</h1>
                                <ul class="breadcrumb">
                                    <li>
                                        <a href="Default.aspx">Home</a>
                                    </li>
                                    <li class="active">Become a Volunteer
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Breadcrumb Section End Here -->

                <div class="container mission-page" id="page-info">
                    <div class="row">
                        <div class="col-xs-12">
                            <!-- Help Us Section Start Here-->
                            <section class="help-us">
                                <header class="page-header section-header clearfix">
                                    <h2>We need you to <strong>Help us around</strong></h2>
                                </header>
                                <figure>
                                    <img src="assets/img/help.jpg" alt="" />
                                </figure>
                            </section>
                            <!-- Help Us Section End Here-->

                            <!-- Process Step Section Start Here-->
                            <section class="process-section anim-section text-center">
                                <header class="page-header section-header clearfix">
                                    <h2>How you can apply, <strong>Here is the process</strong></h2>
                                </header>
                                <div class="row processes">
                                    <div class="col-xs-12 col-sm-3">
                                        <div class="process-step">
                                            Step 1
									
                                        </div>
                                        <h3 class="h4">Create An Account</h3>
                                        <p>
                                            Submit your basic information including Name, Address, and Contact details (including, Gmail or Facebook Id).									
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-3">
                                        <div class="process-step">
                                            Step 2
									
                                        </div>
                                        <h3 class="h4">Attach Image &amp; Signature</h3>
                                        <p>
                                            Attach your passport size picture and signature; this is for authenticity. It also eases the way for us to create identity cards for you.									
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-3">
                                        <div class="process-step">
                                            Step 3
									
                                        </div>
                                        <h3 class="h4">Submit Education &amp; Job Details</h3>
                                        <p>
                                            Now, there is a form, where you need to add your education and professional background details. This helps us to easily divide our team on the basis of role.									
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-3">
                                        <div class="process-step">
                                            Step 4									
                                        </div>
                                        <h3 class="h4">Download Identity Card</h3>
                                        <p>
                                            At last, check all your detailed information and click final to get your identity card. It is valid for 1 year.									
                                        </p>
                                    </div>
                                </div>
                                <p class="text-center">
                                    <a data-toggle="modal" href="~/Error.aspx" data-target=".join-now-form" class="btn btn-default btn-lg join-today">JOIN TODAY</a>
                                </p>
                            </section>
                            <!-- Process Step Section End Here-->
                        </div>
                    </div>
                </div>

            </div>
            <!-- site content ends -->

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

        <!-- join now form popup -->
        <div class="modal join-now-form">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                            &times;					
                        </button>
                        <header class="page-header">
                            <h2>Become a <strong>Volunteer</strong></h2>
                        </header>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group col-xs-12 col-sm-6">
                                    <label for="fname">First Name<span>*</span></label>
                                    <input type="text" class="form-control" runat="server" id="fname" />
                                    <label id="fname-error" style="color: red; display: none;">*</label>
                                </div>
                                <div class="form-group col-xs-12 col-sm-6">
                                    <label for="lname">Last Name<span>*</span></label>
                                    <input type="text" class="form-control" runat="server" id="lname" />
                                    <label id="lname-error" style="color: red; display: none;">*</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group col-xs-12 col-sm-6">
                                    <label for="email">Email<span>*</span></label>
                                    <input type="text" class="form-control"  runat="server" id="email" />
                                    <label id="email-error" style="color: red; display: none;">*</label>
                                </div>
                                <div class="form-group col-xs-12 col-sm-6">
                                    <label for="phone">Phone<span>*</span></label>
                                    <input type="text" class="form-control"  runat="server" id="phone" />
                                    <label id="phone-error" style="color: red; display: none;">*</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group col-xs-12 col-sm-6">
                                    <label for="zip">ZIP code<span>*</span></label>
                                    <input type="text" class="form-control"  runat="server" id="zip" />
                                    <label id="zip-error" style="color: red; display: none;">*</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group col-xs-12">
                                    <label for="message">Why do you want to become a volunteer?<span>*</span></label>
                                    <textarea class="form-control"  runat="server" id="message"></textarea>
                                    <label id="message-error" style="color: red; display: none;">*</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group col-xs-12">                                    
                                    <asp:Button runat="server" ID="btnVolunteer" Text="SUBMIT" class="btn btn-default pull-right" OnClientClick="return validateVolunteer()"/>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group col-xs-12">
                                    <p class="forms-notes">
                                        Note: Thank you for offering us your help.									
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- join now form popup -->

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
