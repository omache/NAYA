﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ourmission.aspx.cs" Inherits="HopeForHumanity.Ourmission" %>

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
    <title>Our Mission - Hope For Humanity</title>
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
        <div id="wrapper" class="mission">
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
                <!--Breadcrumb Section Start Here-->
                <div class="breadcrumb-section">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12">
                                <h1>Our Mission</h1>
                                <ul class="breadcrumb">
                                    <li>
                                        <a href="Default.aspx">Home</a>
                                    </li>
                                    <li class="active">Our Mission
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <!--Breadcrumb Section End Here-->

                <div class="mission-page" id="page-info">
                    <!-- Services Section Start Here-->
                    <section class="container services text-center">
                        <div class="row">
                            <div class="col-xs-12">
                                <header class="service-header section-header">
                                    <h2>What is our mission? <strong>We are on a Mission</strong></h2>
                                </header>

                                <div class="row">
                                    <div class="col-xs-12 col-sm-4 zoom">
                                        <img src="assets/img/icon-service-01.png" alt="" />
                                        <h3 class="h3">Child Development</h3>
                                        <p>
                                            At hope for humanity, we strive to provide holistic development for our children through Love, security and acceptance. This provides good mental health which allows children to think clearly, develop socially and learn new skills in their environment.
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-4 zoom ">
                                        <img src="assets/img/icon-service-02.png" alt="" />
                                        <h3 class="h3">Eradicating Malnutrition</h3>
                                        <p>
                                            We focus on holistic child development and improving survival rate of every child across Africa. Our team also focuses on children who are suffering from life-threatening diseases and are physically challenged. 									
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-4 zoom">
                                        <img src="assets/img/icon-service-03.png" alt="" />
                                        <h3 class="h3">Clothing</h3>
                                        <p>
                                            In chilling waether conditions, every child needs warm cloths, therefore, we are also working at our best capacity to provide all types of clothings to children who do not have proper clothing in such conditions.
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-4 anim-section zoom">
                                        <img src="assets/img/icon-service-04.png" alt="" />
                                        <h3 class="h3">Education Support</h3>
                                        <p>
                                            Children are the future of the world. Hence, we strive to provide better education for our children so that they can make our world a better place. In order to provide valuable education, we are building state-of-the-art infrastructure for these kids.									
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-4 anim-section zoom">
                                        <img src="assets/img/icon-service-05.png" alt="" />
                                        <h3 class="h3">Child Equality</h3>
                                        <p>
                                            There are various areas where children are exploited and deprived of their basic rights. In order to support child equality, we are spearheading campaigns to end the plight of children in Africa.									
                                        </p>
                                    </div>
                                    <div class="col-xs-12 col-sm-4 anim-section zoom">
                                        <img src="assets/img/icon-service-06.png" alt="" />
                                        <h3 class="h3">Health Care</h3>
                                        <p>
                                            Our mission is to provide the finest medical care and treatment for every kind of disease to a child in Africa. We initiate campaigns to reach remote areas and help doctors provide medical care as well as provide all kinds of required medicines.
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                    <!-- Services Section End Here-->

                    <!-- Save Lives Section Start Here-->
                    <section class="save-lives text-center parallax">
                        <div class="container">
                            <div class="row">
                                <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">
                                    <header class="page-header">
                                        <h2>Doante & <strong>Save a life</strong></h2>
                                        <p>
                                            Want to be an active member of our hope for humanity campaign? Just register here and give your donation today.									
                                        </p>
                                    </header>
                                    <a href="Causes.aspx" class="btn btn-default">See our Causes</a>
                                    <a data-toggle="modal" href="~/Error404.aspx" data-target=".donate-form" class="btn btn-default">Donate today</a>
                                </div>
                            </div>
                        </div>
                    </section>
                    <!-- Save Lives Section Start Here-->

                    <!-- We Help Section Start Here -->
                    <section class="we-help text-center">
                        <div class="container">
                            <div class="row">
                                <div class="col-xs-12">
                                    <header class="page-header">
                                        <h2>How We Help, <strong class="border-none">Several Ways</strong></h2>
                                    </header>
                                    <div class="row">
                                        <div class="cols-xs-12 col-sm-6 anim-section">
                                            <div class="thumbnail zoom">
                                                <a href="CauseDetails.aspx?Request=101207" class="img-thumb">
                                                    <img src="assets/img/img-slide-07.jpg" alt="" />
                                                </a>
                                                <div class="caption">
                                                    <h3 class="h3">
                                                        <a href="CauseDetails.aspx?Request=101207">Reunit Children with thier Families
                                                        </a></h3>
                                                    <p>
                                                        Human trafficking is a major issue in the Africa today. We have partnered with various different organizations, who help in finding children who are missing and bring them back to their respectful families.
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="cols-xs-12 col-sm-6 anim-section">
                                            <div class="thumbnail zoom">
                                                <a href="CauseDetails.aspx?Request=101202" class="img-thumb">
                                                    <img src="assets/img/img-slide-03.jpg" alt="" />
                                                </a>
                                                <div class="caption">
                                                    <h3 class="h3"><a href="CauseDetails.aspx?Request=101202">Provide Food</a></h3>
                                                    <p>
                                                        In order to curb malnutrition effectively, our team is working relentlessly to provide the required food materials to children residing in different parts of the continent. 												
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="cols-xs-12 col-sm-6 anim-section">
                                            <div class="thumbnail zoom thumbnail-last">
                                                <a href="CauseDetails.aspx?Request=101204" class="img-thumb">
                                                    <img src="assets/img/img-slide-01.jpg" alt="" />
                                                </a>
                                                <div class="caption">
                                                    <h3 class="h3"><a href="CauseDetails.aspx?Request=101204">Provide Knowledge</a></h3>
                                                    <p>
                                                        We have partnered with various major institutions to assist us in bridging the gap between children and education. Our partners help us provide books and stationary material to the vaious learning institutions.												
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="cols-xs-12 col-sm-6 anim-section">
                                            <div class="thumbnail zoom thumbnail-last ">
                                                <a href="CauseDetails.aspx?Request=101201" class="img-thumb">
                                                    <img src="assets/img/img-slide-02.jpg" alt="" />
                                                </a>
                                                <div class="caption">
                                                    <h3 class="h3"><a href="CauseDetails.aspx?Request=101201">Girls Education </a></h3>
                                                    <p>
                                                        We support equality in learning institutions. Hence, our team strives to provide the best quality education to the marginalised girl child. We are actively involved in encouraging parents to send their girls to our school. 												
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                    <!-- We Help Section Start Here -->

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

        <!-- donation form popup -->
        <div class="modal donate-form">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                            &times;
                        </button>
                        <header class="page-header">
                            <h2>You are donating to. <strong>Hope For Humanity</strong></h2>
                        </header>
                    </div>
                    <div class="modal-body">
                        <div role="form">
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label>How much would you like to donate ?<br /> (NB: We accept bitcoin.)</label>
                                        <div class="choose-pricing">
                                            <div class="btn-group">
                                                <button type="button" class="btn btn-default active" onclick="mySetDonation('25')">
                                                    $25
                                                </button>
                                                <button type="button" class="btn btn-default" onclick="mySetDonation('50')">
                                                    $50
                                                </button>
                                                <button type="button" class="btn btn-default" onclick="mySetDonation('100')">
                                                    $100
                                                </button>
                                                <input type="text" placeholder="Custom" class="inpt-first form-control" runat="server" id="iAmount" />
                                                <asp:HiddenField runat="server" ID="hfAmount" Value="25" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row display">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <div class="dropdown">
                                            <asp:DropDownList ID="ddlType" runat="server" class="btn btn-width dropdown-toggle">
                                                <asp:ListItem Text="Donation Type" Value="Type"></asp:ListItem>
                                                <asp:ListItem Text="Educate A Child" Value="Educate"></asp:ListItem>
                                                <asp:ListItem Text="Feed A Child" Value="Feed"></asp:ListItem>
                                                <asp:ListItem Text="Grow Food" Value="Grow"></asp:ListItem>
                                                <asp:ListItem Text="Build Schools" Value="School"></asp:ListItem>
                                                <asp:ListItem Text="Health Care" Value="Health"></asp:ListItem>
                                            </asp:DropDownList>
                                            <label id="ddlType-error" style="color: red; display: none;">*</label>
                                        </div>
                                    </div>
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <div class="dropdown">
                                            <asp:DropDownList ID="ddlFreq" runat="server" class="btn btn-width dropdown-toggle">
                                                <asp:ListItem Text="One Time Donation" Value="Once" Selected></asp:ListItem>
                                                <asp:ListItem Text="Every Month (Recurring)" Value="Monthly"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label for="name">First Name<span>*</span></label>
                                        <input type="text" class="form-control" id="fname" runat="server" />
                                        <label id="fname-error" style="color: red; display: none;">*</label>
                                    </div>
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label for="last-name">Last Name<span>*</span></label>
                                        <input type="text" class="form-control" id="lname" runat="server" />
                                        <label id="lname-error" style="color: red; display: none;">*</label>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label for="name">Email<span>*</span></label>
                                        <input type="text" class="form-control" id="email" runat="server" />
                                        <label id="email-error" style="color: red; display: none;">*</label>
                                    </div>
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label for="phone">Phone<span>*</span></label>
                                        <input type="text" class="form-control" id="phone" runat="server" />
                                        <label id="phone-error" style="color: red; display: none;">*</label>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label for="message">Address<span>*</span></label>
                                        <textarea class="form-control" id="Address" runat="server"></textarea>
                                        <label id="Address-error" style="color: red; display: none;">*</label>
                                    </div>
                                    <div class="form-group col-xs-12 col-sm-6">
                                        <label for="add-note">Additional Note</label>
                                        <textarea class="form-control" id="message" runat="server"></textarea>
                                        <label id="message-error" style="color: red; display: none;">*</label>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12">
                                        <asp:Button runat="server" ID="btnDonateBitcoin" Text="DONATE WITH BITCOIN" class="btn btn-default pull-left" OnClientClick="return validateForm()" OnClick="btnDonateBitcoin_Click" />
                                        <asp:Button runat="server" ID="btnDonate" Text="DONATE" class="btn btn-default pull-right" OnClientClick="return validateForm()" OnClick="btnDonate_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group col-xs-12">
                                        <p class="forms-notes">
                                            Note: The Hope For Humanity Foundation is a US tax-exempt 501(c)(3) non-profit organization. Your gift is tax-deductible as allowed by law.
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dialog -->
        </div>
        <!-- donation form popup -->

        <script src="assets/js/jquery.min.js"></script>
        <!-- Switcher Style Js -->
        <script src="assets/js/style-switcher/assets/js/style.switcher.js"></script>
        <script src="assets/js/jquery.cookie.js"></script>
        <!-- Bootstrap Js-->
        <script src="assets/js/bootstrap.min.js"></script>
        <script src="assets/js/jquery.easing.min.js"></script>
        <!--Main Slider Js-->
        <script src="assets/revolution-slider/js/jquery.themepunch.plugins.min.js"></script>
        <script src="assets/revolution-slider/js/jquery.themepunch.revolution.js"></script>
        <!--Main Slider Js End -->
        <script src="assets/js/jquery.flexslider.js"></script>
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
