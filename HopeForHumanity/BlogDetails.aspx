﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlogDetails.aspx.cs" Inherits="HopeForHumanity.BlogDetails" %>

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
    <title>Blogs - Hope For Humanity</title>
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
                                <h1>Our Blog</h1>
                                <ul class="breadcrumb">
                                    <li>
                                        <a href="Default.aspx">Home</a>
                                    </li>
                                    <li class="active">Blog
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Breadcrumb Section End Here -->
                <div class="content-wrapper container" id="page-info">
                    <div class="row">
                        <div class="col-xs-12">

                            <div runat="server" id="divBlogDetails">
                                <!--I will autogenerate the blog div from codebehind-->
                            </div>

                            <!--Comments section through discuss api-->
                            <!--Start Disqus-->
                            <div id="disqus_thread"></div>
                            <script>

                                /**
                                *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
                                *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables*/
                                
                                var disqus_config = function () {
                                    this.page.url = 'https://www.newhopeforhumanity.org/BlogDetails.aspx';  // Replace PAGE_URL with your page's canonical URL variable
                                    this.page.identifier = getParameter('Request', window.location.href); // Replace PAGE_IDENTIFIER with your page's unique identifier variable
                                };

                                //My personal code to get url variable
                                function getParameter(name, url) {
                                    if (!url) url = location.href;
                                    name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
                                    var regexS = "[\\?&]" + name + "=([^&#]*)";
                                    var regex = new RegExp(regexS);
                                    var results = regex.exec(url);
                                    return results == null ? null : results[1];
                                }
                                //My personal code to get url variable ends here

                                (function () { // DON'T EDIT BELOW THIS LINE
                                    var d = document, s = d.createElement('script');
                                    s.src = 'https://www-newhopeforhumanity-org.disqus.com/embed.js';
                                    s.setAttribute('data-timestamp', +new Date());
                                    (d.head || d.body).appendChild(s);
                                })();
                            </script>
                            <noscript>Please enable JavaScript to view the <a href="https://disqus.com/?ref_noscript">comments powered by Disqus.</a></noscript>
                            <!--End Disqus-->

                            <!-- leave reply -->
                            <%--<div class="row">
                                <div class="col-xs-12 col-sm-10 col-sm-offset-1">
                                    <div class="reply-form">
                                        <h3>Leave a Reply</h3>
                                        <div class="row">
                                            <div class="col-xs-12 col-sm-6">
                                                <div class="form-group">
                                                    <label for="name">Name<span>*</span></label>
                                                    <input type="text" class="form-control" id="name" />
                                                </div>
                                                <div class="form-group">
                                                    <label for="email">Email<span>*</span></label>
                                                    <input type="email" class="form-control" id="email" />
                                                </div>
                                            </div>
                                            <div class="col-xs-12 col-sm-6">
                                                <div class="form-group">
                                                    <label for="comment">Comment</label>
                                                    <textarea class="form-control" id="comment"></textarea>
                                                </div>

                                                <button type="submit" class="btn btn-default pull-right">
                                                    Submit												
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>--%>
                            <!-- leave reply -->
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
        <script id="dsq-count-scr" src="//www-newhopeforhumanity-org.disqus.com/count.js" async></script>
    </form>
</body>
</html>