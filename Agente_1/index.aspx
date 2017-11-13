<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Agente_1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Inteligencia Artificial</title>
  <!-- Bootstrap core CSS -->
  <link href="bootstrap/css/theme.css" rel="stylesheet">
  <!-- Custom styles for this template -->
  <link href="style.css" rel="stylesheet">
  <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
  <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,300,700,100' rel='stylesheet' type='text/css'>
  <link href='https://fonts.googleapis.com/css?family=Raleway:300,700,900,500' rel='stylesheet' type='text/css'>
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/typicons/2.0.8/typicons.min.css">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
  <link rel="stylesheet" href="assets/css/pushy.css">
  <link rel="stylesheet" href="assets/css/masonry.css">
  <link rel="stylesheet" href="assets/css/animate.css">
  <link rel="stylesheet" href="assets/css/magnific-popup.css">
  <link rel="stylesheet" href="assets/css/odometer-theme-default.css">
  <script>
  window.odometerOptions = {
    selector: '.odometer',
    format: '(,ddd)', // Change how digit groups are formatted, and how many digits are shown after the decimal point
    duration: 13000, // Change how long the javascript expects the CSS animation to take
    theme: 'default'
  };
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class=""></div>
      <!-- Pushy Menu -->
  <nav class="pushy pushy-left">
    <ul class="list-unstyled">
      <li><a href="#home">Inicio</a></li>
      <li><a href="#feat">Reglas</a></li>
      <li><a href="#history">Integrantes</a></li>
    </ul>
  </nav>
<!-- Pushy Menu -->
  <nav class="pushy pushy-left">
    <ul class="list-unstyled">
      <li><a href="#home">Inicio</a></li>
      <li><a href="#feat">Reglas</a></li>

      <li><a href="#history">Integrantes</a></li>

    </ul>
  </nav>

    <div class="site-overlay"></div>
    <header id="home">
        <div class="container-fluid">
            <div class="container">
        <div class="row">
          <div class="col-md-3 col-xs-10">
            <!--  <a href="#" class="thumbnail logo">
            <img src="images/your_logo.png" alt="" class="img-responsive">
          </a> -->
          <div class="jumbotron">
            <h1><small>Inteligencia</small><br/>
              <strong>Artificial</strong></h1>
            </div>
          </div>
          <div class="col-md-1 col-md-offset-8 col-xs-2 text-center">
            <div class="menu-btn"><span class="hamburger"><i class="fa fa-bars"></i></span></div>
          </div>
        </div>
           <div class="row">
            <div class="text-center">
            <p>
              <br/>
              <br/>
              <br/>

              <button  type="button" class="btn btn-lg btn-danger">Iniciar</button>
            </p>
                </div>
            </div>
        </div>
        </div>
    </header>
    <section id="feat">
        <div class="container">
            <div class="row features">
                <div class="col-md-4 text-center wow fadeInUp" data-wow-delay="100ms">
                    <span class="typcn typcn-pencil x3"></span>
                    <h4>Regla 1</h4>
                    <p>Describir la regla...</p>
                </div>
                <div class="col-md-4 text-center wow fadeInUp" data-wow-delay="300ms">
                    <span class="typcn typcn-pencil x3"></span>
                    <h4>Regla 2</h4>
                    <p>Describir la regla...</p>
                </div>
                <div class="col-md-4 text-center wow fadeInUp" data-wow-delay="500ms">
                    <span class="typcn typcn-pencil x3"></span>
                    <h4>Regla 3</h4>
                    <p>Describir la regla....</p>
                </div>
            </div>
        </div>
    </section>
    <section id="history" class="story wow fadeInUp" data-wow-delay="300ms">
        <div class="container-fluid">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 opaline">
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <!--<p class="lead"><i>Integrantes:</i></p>-->
                                <h6 class="lead"> – Integrantes</h6>
                                <p><i>-Derly Viviana Murcia</i></p>
                                <p><i>-Diego Fernado Jojoa</i></p>
                                <p><i>-Nicol Dayana Endo Ruiz</i></p>
                                <p><i>-Raul Fernando Cedeño</i></p>
                                <p><i>-Juan david Cubillos</i></p>
                                <p><i>-Brayan Poveda</i></p>
                                <p><i>-David Fernando Calderon</i></p>
                                <p><i>-Andres Hinestroza</i></p>
                                <p><i>-Mateo Ceballos</i></p>
                                <h6 class="lead"> – Docente</h6>
                                <p><i> - Ing. Milher Fabian Tovar Rubiano</i></p>
                                <p>
                                    <small>
                                        Asignatura: <br>
                                        Inteligencia Artificial.
                                    </small>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <br />
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-md-8">
                    <h3>UDLA</h3>
                    <p>© 2017 Inteligencia Artificial. Designed by <a target="_blank" href="https://www.facebook.com/diegojojoa1994">Diego Jojoa</a></p>
                </div>
                <div class="col-md-4">
                    <p class="text-right social">
                        <a href="https://www.facebook.com/diegojojoa1994" target="_blank"><i class="typcn typcn-social-facebook-circular"></i></a>
                        <a href="#" target="_blank"><i class="typcn typcn-social-twitter-circular"></i></a>
                        <!--  <i class="typcn typcn-social-tumbler-circular"></i>
                          <i class="typcn typcn-social-github-circular"></i>
                          <i class="typcn typcn-social-dribbble-circular"></i> -->
                    </p>
                </div>
            </div>
        </div>
    </footer>
    <script src="assets/js/jquery.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="https://netdna.bootstrapcdn.com/twitter-bootstrap/2.0.4/js/bootstrap-scrollspy.js"></script>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="assets/js/ie10-viewport-bug-workaround.js"></script>
    <script src="http://masonry.desandro.com/masonry.pkgd.js"></script>
    <script src="assets/js/masonry.js"></script>
    <script src="assets/js/pushy.min.js"></script>
    <script src="assets/js/jquery.magnific-popup.min.js"></script>
    <script src="assets/js/wow.min.js"></script>
    <script src="assets/js/scripts.js"></script>
    <script src="assets/js/odometer.js"></script>

    </form>
</body>
</html>

    <script>
    (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
      (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
      m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
    })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

    ga('create', 'UA-34344036-1', 'auto');
    ga('send', 'pageview');

    </script>
