
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Okul.aspx.cs" EnableEventValidation="false" Inherits="Proje.WebKalitim.neos.Okul" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Neos &mdash; Website Template by Colorlib</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">


    <link href="https://fonts.googleapis.com/css?family=Oswald:400,700|Work+Sans:300,400,700" rel="stylesheet">
    <link rel="stylesheet" href="fonts/icomoon/style.css">

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">
    <link rel="stylesheet" href="css/jquery-ui.css">
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/bootstrap-datepicker.css">
    <link rel="stylesheet" href="css/animate.css">    
    
    <link rel="stylesheet" href="fonts/flaticon/font/flaticon.css">
  
    <link rel="stylesheet" href="css/aos.css">

    <link rel="stylesheet" href="css/style.css">
    
  </head>
<body>
    <form id="form1" runat="server">
     <asp:objectdatasource runat="server"></asp:objectdatasource>

    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
  <div class="loader">
    <div class="spinner-border text-primary" role="status">
      <span class="sr-only">Loading...</span>
    </div>
  </div>

  <div class="site-wrap">

    

    <div class="site-mobile-menu">
      <div class="site-mobile-menu-header">
        <div class="site-mobile-menu-close mt-3">
          <span class="icon-close2 js-menu-toggle"></span>
        </div>
      </div>
      <div class="site-mobile-menu-body"></div>
    </div> <!-- .site-mobile-menu -->
    
    
    <div class="site-navbar-wrap js-site-navbar bg-white">
      
      <div class="container">
        <div class="site-navbar bg-light">
          <div class="row align-items-center">
            <div class="col-2">
              <h2 class="mb-0 site-logo"><a href="index.html" class="font-weight-bold text-uppercase">Neos</a></h2>
            </div>
            <div class="col-10">
              <nav class="site-navigation text-right" role="navigation">
                <div class="container">
                  <div class="d-inline-block d-lg-none ml-md-0 mr-auto py-3"><a href="#" class="site-menu-toggle js-menu-toggle text-black"><span class="icon-menu h3"></span></a></div>

                   <ul class="site-menu js-clone-nav d-none d-lg-block">
                    <li class="active"><a href="index.html">Anasayfa</a></li>
                   <%-- <li class="has-children">
                      <a href="about.html">About</a>
                      <ul class="dropdown arrow-top">
                        <li><a href="testimonials.html">Testimonials</a></li>
                        <li><a href="gallery.html">Gallery</a></li>
                        <li><a href="faq.html">FAQ</a></li>
                        <li><a href="why-choose-us.html">Why Choose Us</a></li>
                        <li class="has-children">
                          <a href="#">Sub Menus</a>
                          <ul class="dropdown">
                            <li><a href="testimonials.html">Testimonials</a></li>
                            <li><a href="gallery.html">Gallery</a></li>
                            <li><a href="why-choose-us.html">Why Choose Us</a></li>
                          </ul>
                        </li>
                      </ul>
                    </li>--%>
                    <li><a href="Okul.aspx">Okul</a></li>
                    <li><a href="Bolum.aspx">Bölüm</a></li>
                    <li><a href="contact.html">Program</a></li>
                    <li><a href="contact.html"><span class="d-inline-block bg-primary text-white btn btn-primary">Get Started</span></a></li>
                  </ul>
                </div>
              </nav>
            </div>
          </div>
        </div>
      </div>
    </div>
  
       

    <div class="slant-1"></div>

    
    
  <div class="site-section first-section">
      <div class="container">
         
        <div class="row border-responsive">
          <div class="col-md-6 col-lg-4 mb-4 mb-lg-4 border-right" data-aos="fade-up" data-aos-delay="">
            <div class="text-center">
              <span class="flaticon-money-bag-with-dollar-symbol display-4 d-block mb-3 text-primary"></span>
              <h3 class="text-uppercase h4 mb-3">
               <asp:Button ID="Button1" runat="server" CssClass="btn btn-bg-primary" BackColor="Black" Text="Okul Bilgisi Getir" OnClick="Button1_Click" /></h3>
              <p>
         <asp:Label ID="Label1" runat="server" Text=""></asp:Label></p>
            </div>
          </div>
          <div class="col-md-6 col-lg-4 mb-4 mb-lg-4 border-right" data-aos="fade-up" data-aos-delay="100">
            <div class="text-center">
              <span class="flaticon-bar-chart display-4 d-block mb-3 text-primary"></span>
              <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okulad" placeholder="Okul Adı Giriniz" runat="server"></asp:TextBox></h3>
              <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okuladres" placeholder="Okul Adresi Giriniz" runat="server"></asp:TextBox></h3>
                <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okultel" placeholder="Okul Telini Giriniz" runat="server"></asp:TextBox></h3>
                <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okulkodu" placeholder="Okul Kodunu Giriniz" runat="server"></asp:TextBox></h3>
             <h3 class="text-uppercase h4 mb-3"><asp:Button ID="Button2" runat="server" CssClass="btn btn-bg-primary" BackColor="Black" Text="Okul Bilgisi Ekle" OnClick="Button2_Click" /></h3>
              <h3 class="text-uppercase h4 mb-3"><asp:Button ID="Button3" runat="server" CssClass="btn btn-bg-primary" BackColor="Black" Text="Bolum Ekle" OnClick="Button3_Click" /></h3>
                
                  <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque, nobis?</p>
            </div>
          </div>
          <div class="col-md-6 col-lg-4 mb-4 mb-lg-4" data-aos="fade-up" data-aos-delay="200">
            <div class="text-center">
              <span class="flaticon-medal display-4 d-block mb-3 text-primary"></span>
               <h3 class="text-uppercase h4 mb-3">
             <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="OkulAdi" DataValueField="OkulId" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:LabSistemiConnectionString %>" SelectCommand="SELECT * FROM [Okul]"></asp:SqlDataSource>
                </h3>
                <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okuladyeni" placeholder="Okul Adı Giriniz" runat="server"></asp:TextBox></h3>
              <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okuladresyeni" placeholder="Okul Adresi Giriniz" runat="server"></asp:TextBox></h3>
                <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okultelyeni" placeholder="Okul Telini Giriniz" runat="server"></asp:TextBox></h3>
                <h3 class="text-uppercase h4 mb-3"><asp:TextBox ID="txt_okulkodyeni" placeholder="Okul Kodunu Giriniz" runat="server"></asp:TextBox></h3>
                <h3 class="text-uppercase h4 mb-3"><asp:Button ID="Button4" runat="server" CssClass="btn btn-bg-primary" BackColor="Black" Text="Okul Bilgisi Güncelle" OnClick="Button4_Click" /></h3>

            </div>
          </div>
          <div class="col-md-6 col-lg-4 mb-4 mb-lg-4 border-right" data-aos="fade-up" data-aos-delay="">
            <div class="text-center">
              <span class="flaticon-box display-4 d-block mb-3 text-primary"></span>
              <h3 class="text-uppercase h4 mb-3">Free Package</h3>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque, nobis?</p>
            </div>
          </div>

          <div class="col-md-6 col-lg-4 mb-4 mb-lg-4 border-right" data-aos="fade-up" data-aos-delay="100">
            <div class="text-center">
              <span class="flaticon-medal display-4 d-block mb-3 text-primary"></span>
              <h3 class="text-uppercase h4 mb-3">3 Years Experience</h3>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque, nobis?</p>
            </div>
          </div>
          <div class="col-md-6 col-lg-4 mb-4 mb-lg-4" data-aos="fade-up" data-aos-delay="200">
            <div class="text-center">
              <span class="flaticon-box display-4 d-block mb-3 text-primary"></span>
              <h3 class="text-uppercase h4 mb-3">Free Package</h3>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eaque, nobis?</p>
            </div>
          </div>
        </div>
      </div>
    </div>

  
    <div class="site-section section-counter">
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <p class="mb-5"><img src="images/img_1.jpg" alt="Image" class="img-fluid"></p>
          </div>
          <div class="col-lg-5 ml-auto">
            <h2 class="site-section-heading mb-3 font-secondary text-uppercase">Free Templates By Colorlib</h2>
            <p class="mb-5">Ullam ut modi cum voluptatibus atque nulla quidem maxime enim animi cupiditate, mollitia. </p>

            <div class="row">
              <div class="col-lg-6">
                <div class="counter">
                  <span class="caption">Current Downloads</span>
                  <span class="number" data-number="49020">0</span>
                </div>
              </div>
              <div class="col-lg-6">
                <div class="counter">
                  <span class="caption">Number of Templates</span>
                  <span class="number" data-number="275">0</span>
                </div>
              </div>
            </div>
            
          </div>
        </div>
      </div>
    </div>

    

    <div class="py-5 bg-primary">
      <div class="container">
        <div class="row align-items-center justify-content-center">
          <div class="col-md-6 text-center mb-3 mb-md-0">
            <h2 class="text-uppercase text-white mb-4">Try For Your Next Project</h2>
            <a href="#" class="btn btn-bg-primary font-secondary text-uppercase">Contact Us</a>
          </div>
        </div>
      </div>
    </div>

    <footer class="site-footer bg-dark">
      <div class="container">
        

        <div class="row">
          <div class="col-md-4 mb-4 mb-md-0">
            <h3 class="footer-heading mb-4 text-white">About</h3>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellat quos rem ullam, placeat amet.</p>
            <p><a href="#" class="btn btn-primary text-white px-4">Read More</a></p>
          </div>
          <div class="col-md-5 mb-4 mb-md-0 ml-auto">
            <div class="row mb-4">
              <div class="col-md-6">
                <h3 class="footer-heading mb-4 text-white">Quick Menu</h3>
                  <ul class="list-unstyled">
                    <li><a href="#">Home</a></li>
                    <li><a href="#">About</a></li>
                    <li><a href="#">Blog</a></li>
                    <li><a href="#">Contacts</a></li>
                    <li><a href="#">Privacy</a></li>
                  </ul>
              </div>
              <div class="col-md-6">
                <h3 class="footer-heading mb-4 text-white">Free Templates</h3>
                  <ul class="list-unstyled">
                    <li><a href="#">HTML5 / CSS3</a></li>
                    <li><a href="#">Clean Design</a></li>
                    <li><a href="#">Responsive</a></li>
                    <li><a href="#">Multi Purpose Template</a></li>
                  </ul>
              </div>
            </div>

            <div class="row mb-5">
              <div class="col-md-12">
              <h3 class="footer-heading mb-4 text-white">Stay up to date</h3>
              <form action="#" class="d-flex footer-subscribe">
                  Bolum
                <input type="submit" class="btn btn-primary rounded-0" value="Subscribe">
              </form>
            </div>
            </div>
          </div>

          
          <div class="col-md-2">
            
            <div class="row">
            <div class="col-md-12"><h3 class="footer-heading mb-4 text-white">Social Icons</h3></div>
              <div class="col-md-12">
                <p>
                  <a href="#" class="pb-2 pr-2 pl-0"><span class="icon-facebook"></span></a>
                  <a href="#" class="p-2"><span class="icon-twitter"></span></a>
                  <a href="#" class="p-2"><span class="icon-instagram"></span></a>
                  <a href="#" class="p-2"><span class="icon-vimeo"></span></a>

                </p>
              </div>
          </div>
          </div>
        </div>
        <div class="row pt-5 mt-5 text-center">
          <div class="col-md-12">
            <p>
            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
            Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class="icon-heart text-danger" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank" >Colorlib</a>
            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
            </p>

            
          </div>
          
        </div>
      </div>
    </footer>
  </div>

  <script src="js/jquery-3.3.1.min.js"></script>
  <script src="js/jquery-migrate-3.0.1.min.js"></script>
  <script src="js/jquery-ui.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/jquery.stellar.min.js"></script>

  <script src="js/jquery.waypoints.min.js"></script>
  <script src="js/jquery.animateNumber.min.js"></script>
  <script src="js/aos.js"></script>

  <script src="js/main.js"></script>

  </form>
</body>
</html>
