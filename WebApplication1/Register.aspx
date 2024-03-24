<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register"  %>
<%@ Import Namespace="System.Data.SqlClient" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Register - TechStore</title>
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
<br /><br />
                <main class="main-content  mt-0">
    <section>
        <div class="page-header min-vh-100">
            <div class="container">
                <div class="row">
                    <div class="col-6 d-lg-flex d-none h-100 my-auto pe-0 position-absolute top-0 start-0 text-center justify-content-center flex-column">
                        <div class="position-relative bg-gradient-primary h-100 m-3 px-7 border-radius-lg d-flex flex-column justify-content-center" style="background-image: url('img/banner.png'); background-size: cover;">
                        </div>
                    </div>
                    <div class="col-xl-4 col-lg-5 col-md-7 d-flex flex-column ms-auto me-auto ms-lg-auto me-lg-5">
                        <div class="card card-plain">
                            <div class="card-header">
                                <h4 class="font-weight-bolder">Sign Up</h4>
                                <p class="mb-0">Enter your email and password to register</p>
                            </div>
                            <div class="card-body">
                                <form role="form" method="post">
                                    <div class="input-group input-group-outline mb-3">
                                        <input minLength="4" name="name" placeholder="Name" required type="text" class="form-control">
                                    </div>
                                    <div class="input-group input-group-outline mb-3">
                                        <input minLength="4" name="email" placeholder="Email" required type="email" class="form-control">
                                    </div>
                                    <div class="input-group input-group-outline mb-3">
                                        <input minLength="10" name="phone" placeholder="Phone" required type="tel" class="form-control">
                                    </div>
                                    <div class="input-group input-group-outline mb-3">
                                        <input minLength="6" name="address" placeholder="Adress" required type="address" class="form-control">
                                    </div>
                                    <div class="input-group input-group-outline mb-3">
                                        <input minLength="6" name="pwd" placeholder="Password" required type="password" class="form-control">
                                    </div>
                                    <div class="form-check form-check-info text-start ps-0">
                                        <input required class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                        <label class="form-check-label" for="flexCheckDefault">
                                            I agree the <a href="javascript:;" class="text-dark font-weight-bolder">Terms and Conditions</a>
                                        </label>
                                    </div>
                                    <div class="text-center">
                                        <button type="submit" class="btn btn-lg bg-gradient-primary btn-lg w-100 mt-4 mb-0">Sign Up</button>
                                    </div>
                                </form>
                                <%=msg %>
                            </div>
                            <div class="card-footer text-center pt-0 px-lg-2 px-1">
                                <p class="mb-2 text-sm mx-auto">
                                    Already have an account?
                                    <a href="/Login" class="text-primary text-gradient font-weight-bold">Sign in</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </main>
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
