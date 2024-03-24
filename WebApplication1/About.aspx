<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About"  %>
<%@ Import Namespace="System.Data.SqlClient" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>About - TechStore</title>
    <link id="pagestyle" href="lib/material/css/material-dashboard.css?v=3.0.4" rel="stylesheet" />
    <link rel="stylesheet" href="css/site.css" asp-append-version="true" />
    <link rel="stylesheet" href="/WebApplication.styles.css" asp-append-version="true" />
    <link href="lib/material/css/nucleo-icons.css" rel="stylesheet" />
    <link href="lib/material/css/nucleo-svg.css" rel="stylesheet" />
    <link rel="icon" href="/favicon.ico" type="image/x-icon">
    <link rel="shortcut icon" href="/favicon.ico" type="image/x-icon">
    <script src="https://kit.fontawesome.com/42d5adcbca.js" crossorigin="anonymous"></script>
    <script src="https://unpkg.com/@dotlottie/player-component@latest/dist/dotlottie-player.mjs" type="module"></script>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons+Round" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700,900|Roboto+Slab:400,700" />
</head>
<body>
    <header id="header" class="container position-sticky z-index-sticky "><br /><br /><br />
        <div class="row">
            <div class="col-12">
                <!-- Navbar -->
                <nav class="navbar navbar-expand-lg blur border-radius-xl top-0 z-index-3 shadow position-absolute my-3 py-2 start-0 end-0 mx-4">
                    <div class="container-fluid ps-2 pe-0">
                        <a class="navbar-brand font-weight-bolder ms-lg-0 ms-3 " href="/Home">
                            TechStore
                        </a>
                        <button class="navbar-toggler shadow-none ms-2" type="button" data-bs-toggle="collapse" data-bs-target="#navigation" aria-controls="navigation" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon mt-2">
                                <span class="navbar-toggler-bar bar1"></span>
                                <span class="navbar-toggler-bar bar2"></span>
                                <span class="navbar-toggler-bar bar3"></span>
                            </span>
                        </button>
                        <div class="collapse navbar-collapse" id="navigation">
                            <ul class="navbar-nav mx-auto">
                                <li class="nav-item">
                                    <a class="nav-link d-flex align-items-center me-2 active" aria-current="page" href="/Cart">
                                        <i class="fa fa-shopping-cart opacity-6 text-dark me-1"></i>
                                        Cart
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link me-2" href="/Profile">
                                        <i class="fa fa-user opacity-6 text-dark me-1"></i>
                                        Profile
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link me-2" href="/History">
                                        <i class="fa fa-history opacity-6 text-dark me-1"></i>
                                        History
                                    </a>
                                </li>
                                <li id="login" class="nav-item">
                                    <a class="nav-link me-2" href="/Login">
                                        <i class="fas fa-sign-in opacity-6 text-dark me-1"></i>
                                        Sign In
                                    </a>
                                </li>
                                <!--<li class="nav-item">
                                    <a class="nav-link me-2" href="/About">
                                        <i class="fas fa-info opacity-6 text-dark me-1"></i>
                                        About us
                                    </a>
                                </li>-->
                                <li class="nav-item">
                                    <a class="nav-link me-2" href="/Logout">
                                        <i class="fas fa-times-circle opacity-6 text-dark me-1"></i>
                                        Sign Out
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <form action="Search.aspx" method="get">
                                        <div class="collapse navbar-collapse mt-sm-0 mt-2 me-md-0 me-sm-4" id="navbar">
                                            <div class="ms-md-auto pe-md-3 d-flex align-items-center">
                                                <div class="input-group input-group-outline">
                                                    <!-- <label class="form-label">Type here...</label> -->
                                                    <input name="p" type="text" placeholder="Search" class="form-control">
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>
                <!-- End Navbar -->
            </div>
        </div>
    </header>
    <div class="container">
        <main role="main" class="pb-3">

<div class="container-fluid py-4">
            <div class="row mt-auto">
<section id="what-we-do">
	<div class="container-fluid">
		<h2 class="section-title text-center mb-2 h1">About TechStore</h2>
		<p class="text-center text-muted h5">Here at TechStore we believe that the customers satisfaction is primordial.</p>
		<div class="row mt-5">
			<div class="col-xs-12 col-sm-6 col-md-4 col-lg-4 col-xl-4">
				<div class="card text-center">
					<div class="card-header">
						<dotlottie-player src="https://lottie.host/c4fa22aa-85fe-4aa3-94ff-de6b50337e7b/0XWUqryIej.json" background="transparent" speed="1" style="width: 300px; height: 300px" direction="1" mode="normal" loop autoplay></dotlottie-player>
					</div>
					<div class="card-block block-1">
						<h3 class="card-title">Our Staff</h3>
						<p class="card-text">We train our staff regurlarly to maintain highest order of service.</p>
						
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-sm-6 col-md-4 col-lg-4 col-xl-4">
				<div class="card text-center">
					<div class="card-header">
						<dotlottie-player src="https://lottie.host/938596b0-bd52-4bcb-aab0-8dd586059e18/bcGw4GueRw.json" background="transparent" speed="1" style="width: 300px; height: 300px" direction="1" mode="normal" loop autoplay></dotlottie-player>
					</div>
					<div class="card-block block-2">
						<h3 class="card-title">Carbon Free</h3>
						<p class="card-text">We work with other companies to ensure minimal waste to increase the quality of life for the environment.</p>
						
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-sm-6 col-md-4 col-lg-4 col-xl-4">
				<div class="card text-center">
					<div class="card-header">
						<dotlottie-player src="https://lottie.host/8df930e7-fa12-44a7-810f-b86181d47cb4/Im6Jp2gm8w.json" background="transparent" speed="1" style="width: 300px; height: 300px" direction="1" mode="normal" loop autoplay></dotlottie-player>
					</div>
					<div class="card-block block-3">
						<h3 class="card-title">Foundation</h3>
						<p class="card-text">We work with other companies such as the libearion army to bring about good social development by empowering the youth and innovation.</p>
						
					</div>
				</div>
			</div>
		</div>
		<div class="row">
			<div class="col-xs-12 col-sm-6 col-md-4 col-lg-4 col-xl-4">
				<div class="card text-center">
					<div class="card-header">
						<dotlottie-player src="https://lottie.host/72f67e4c-29be-43c8-aef6-5c4ce2146bc0/Cypd0H5Etz.json" background="transparent" speed="1" style="width: 300px; height: 300px" direction="1" mode="normal" loop autoplay></dotlottie-player>
					</div>
					<div class="card-block block-4">
						<h3 class="card-title">Contact Us</h3>
						<p class="card-text">Find us on Email at support@TechStore.com</p>
						<p class="card-text">Find us on Tel: +1 362 727</p>
					</div>
				</div>
			</div>
		</div>
	</div>
</section>
            </div>
        </div>

        </main>
    </div>
    <footer  class="footer position-absolute bottom-2 py-2 w-100" >
        <div id="footer" class="container">
            <div class="row align-items-center justify-content-lg-between">
                <div class="col-12 col-md-6 my-auto">
                    <div class="copyright text-center text-sm  text-lg-start">
                        © <script>
                              document.write(new Date().getFullYear()) 
                        </script>,
                        made with <i class="fa fa-heart" aria-hidden="true"></i> by
                        <a href="https://techstore.com" target="_blank" class="font-weight-bold ">TechStore</a>
                        for a better web.
                    </div>
                </div>
                <div class="col-12 col-md-6">
                    <ul class="nav nav-footer justify-content-center justify-content-lg-end">
                        <li class="nav-item">
                            <a class="nav-link " href="/About">About Us</a>
                        </li>
                        <li class="nav-item">
                            <a href="mailto: support@TechStore.com"  class="nav-link " >Support</a>
                        </li>
                        <li class="nav-item" >
                            <a href="/Logout" class="nav-link pe-0 ">Log Out</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>

    <script>

        let role = getCookie("role");
        if (role != "") {
            var login = document.getElementById("login")
            login.style.display = "none"
            var footer = document.getElementById("footer")
            var header = document.getElementById("header")
            if(role != "0"){
                header.style.display = "block"
                footer.style.display = "block"
            }
        }

        function getCookie(cname) {
            let name = cname + "=";
            let ca = document.cookie.split(';');
            for (let i = 0; i < ca.length; i++) {
                let c = ca[i];
                while (c.charAt(0) == ' ') {
                    c = c.substring(1);
                }
                if (c.indexOf(name) == 0) {
                    return c.substring(name.length, c.length);
                }
            }
            return "";
        }
    </script>

    <script src="/lib/jquery/dist/jquery.min.js"></script>
    <script src="https://kit.fontawesome.com/42d5adcbca.js" crossorigin="anonymous"></script>
    <script async defer src="https://buttons.github.io/buttons.js"></script>
    <script src="/lib/material/js/material-dashboard.min.js?v=3.0.4"></script>
    <script src="/js/site.js" asp-append-version="true"></script>
    <script src="/js/lottie.js"></script>
</body>
</html>
