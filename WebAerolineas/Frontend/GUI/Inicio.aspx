<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/MasterPage/FrontEnd.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebAerolineas.Frontend.GUI.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="bend niceties preview-2">
        <div id="ensign-nivoslider" class="slides">
            <img src="../Recursos/img/slider/fondo1.jpg" alt="" title="#slider-direction-1" />
            <img src="../Recursos/img/slider/fondo2.jpg" alt="" title="#slider-direction-2" />
            <img src="../Recursos/img/slider/fondo3.jpg" alt="" title="#slider-direction-3" />
        </div>

        <!-- direction 1 -->
        <div id="slider-direction-1" class="slider-direction slider-one">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="slider-content">
                            <!-- layer 1 -->
                            <div class="layer-1-1 hidden-xs wow slideInDown" data-wow-duration="2s" data-wow-delay=".2s">
                                <h2 class="title1">The Best Business Information </h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-1-2 wow slideInUp" data-wow-duration="2s" data-wow-delay=".1s">
                                <h1 class="title2">We're In The Business Of Helping You Start Your Business</h1>
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-1-3 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                <a class="ready-btn right-btn page-scroll" data-toggle="modal" data-target="#login-modal">Iniciar sesion</a>
                                <a class="ready-btn page-scroll">Registrarse</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- direction 2 -->
        <div id="slider-direction-2" class="slider-direction slider-two">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="slider-content text-center">
                            <!-- layer 1 -->
                            <div class="layer-1-1 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                <h2 class="title1">The Best Business Information </h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-1-2 wow slideInUp" data-wow-duration="2s" data-wow-delay=".1s">
                                <h1 class="title2">We're In The Business Of Get Quality Business Service</h1>
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-1-3 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                <a class="ready-btn right-btn page-scroll" data-toggle="modal" data-target="#login-modal">Iniciar sesion</a>
                                <a class="ready-btn page-scroll">Registrarse</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- direction 3 -->
        <div id="slider-direction-3" class="slider-direction slider-two">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="slider-content">
                            <!-- layer 1 -->
                            <div class="layer-1-1 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                <h2 class="title1">The Best business Information </h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-1-2 wow slideInUp" data-wow-duration="2s" data-wow-delay=".1s">
                                <h1 class="title2">Helping Business Security  & Peace of Mind for Your Family</h1>
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-1-3 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                <a class="ready-btn right-btn page-scroll" data-toggle="modal" data-target="#login-modal">Iniciar sesion</a>
                                <a class="ready-btn page-scroll">Registrarse</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    

    <div class="modal fade" id="login-modal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" style="display: none;">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="loginmodal-container">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                <h5 class="modal-title" id="exampleModalLabel">Inicio de sesion</h5>                                   
                </div>                                               
                <div class="modal-body">
                     <br>
                    <h6 class="alignleft" id="exampleModalLabel3">Correo</h6>
                    <asp:TextBox ID="txtid" runat="server" CssClass="form-control btn-block" placeholder="Correo electronico"></asp:TextBox><br />
                  <h6 class="alignleft" id="exampleModalLabel4">Contraseña</h6>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control btn-block" placeholder="Contraseña" type="password"></asp:TextBox>                                                      
                </div>
                <div class="modal-footer">
                    <asp:Button ID="Button1" runat="server" Height="40px" Text="Ingresar" CssClass="form-control btn btn-block btn-primary"/>  
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="section-headline text-center">
                    <h2>Misión</h2>
                </div>
            </div>
        </div>
        <div class="row">

            <!-- single-well start-->

            <!-- single-well end-->
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="well-middle">
                    <div class="single-well">
                        <a href="#">
                            <h4 class="sec-head">La misión de Aerolineas AirFly se orienta hacia tres objetivos principales:</h4>
                        </a>

                        <ul>
                            <li class="text-left">
                                <i class="fa fa-check"></i>Incrementar la presencia internacional de Aerolineas AirFly como operador global de infraestructuras aeronáuticas, proporcionando servicios de gestión de aeropuertos con seguridad, eficacia, eficiencia y respeto al medio ambiente, buscando siempre la rentabilidad en cada una de las operaciones.
                                   </li>
                            <li class="text-left">
                                <i class="fa fa-check"></i>Potenciar el desarrollo corporativo de Aerolineas AirFly.
                                 </li>
                            <li class="text-left">
                                <i class="fa fa-check"></i>Favorecer la presencia empresarial e institucional mexicana en el ámbito internacional.
                                 </li>
                            <br />
                        </ul>
                        <p>
                            Con estos objetivos Aerolineas AirFly concurre a licitaciones para gestionar y operar infraestructuras aeroportuarias en diferentes lugares del mundo, con una especial vocación hacia aquéllas que se desarrollan en América Latina y Europa pero sin perder de vista los mercados emergentes como Oriente Medio o Asia.             
                        </p>
                    </div>
                </div>
            </div>
            <!-- End col-->
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="section-headline text-center">
                    <h2>Vision</h2>
                </div>
            </div>
        </div>
        <div class="row">


            <!-- single-well end-->
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="well-middle">
                    <div class="single-well">

                        <p>
                            Ser la aerolínea mexicana reconocida, nacional e internacionalmente por su calidad de servicios y la mayor cantidad de destinos, para conquistar y mantener la fidelidad de nuestros clientes en armonía con la sociedad y el medio ambiente.
                        </p>
                    </div>
                </div>
            </div>
            <!-- End col-->
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="section-headline services-head text-center">
                    <h2>Valores</h2>
                </div>
            </div>
        </div>
        <div class="row text-center">
            <div class="services-contents">
                <!-- Start Left services -->
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="about-move">
                        <div class="services-details">
                            <div class="single-services">
                                <a class="services-icon" href="#">
                                    <i class="fa fa-black-tie"></i>
                                </a>
                                <h4>Respeto</h4>
                                <p class="text-left">
                                    Creamos un ambiente de convivencia organizacional, basado en la aceptación del otro tal como es, escuchando y valorando su punto de vista; Brindando un trato cordial y empático.
                                </p>
                            </div>
                        </div>
                        <!-- end about-details -->
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <div class="about-move">
                        <div class="services-details">
                            <div class="single-services">
                                <a class="services-icon" href="#">
                                    <i class="fa fa-camera-retro"></i>
                                </a>
                                <h4>Sentido de Pertenencia</h4>
                                <p class="text-left">
                                    Asumimos a la organización como nuestra, cuidando su imagen y recursos, haciendo de Aerolineas AirFly un espacio de servicio con excelencia y mostrando, en todo momento nuestro orgullo de estar en ella.         
                                </p>
                            </div>
                        </div>
                        <!-- end about-details -->
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <!-- end col-md-4 -->
                    <div class=" about-move">
                        <div class="services-details">
                            <div class="single-services">
                                <a class="services-icon" href="#">
                                    <i class="fa fa-wordpress"></i>
                                </a>
                                <h4>Honestidad</h4>
                                <p class="text-left">
                                    Nuestro comportamiento es congruente con los valores y normas de la organización; actuamos comprometidos con la verdad y lo justo; Cuidando como propios los bienes y recursos de la organización.             
                                </p>
                            </div>
                        </div>
                        <!-- end about-details -->
                    </div>
                </div>
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <!-- end col-md-4 -->
                    <div class=" about-move">
                        <div class="services-details">
                            <div class="single-services">
                                <a class="services-icon" href="#">
                                    <i class="fa fa-camera-retro"></i>
                                </a>
                                <h4>Compromiso</h4>
                                <p class="text-left">
                                    Lograr los objetivos de Aerolineas AirFly es nuestro fuerte, los asumimos con pasión, poniendo nuestras mejores cualidades personales y de equipo para alcanzarlos, superando los obstáculos con creatividad e iniciativa en el marco de los lineamientos organizacionales.
                                   
                                </p>
                            </div>
                        </div>
                        <!-- end about-details -->
                    </div>
                </div>
                <!-- End Left services -->
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <!-- end col-md-4 -->
                    <div class=" about-move">
                        <div class="services-details">
                            <div class="single-services">
                                <a class="services-icon" href="#">
                                    <i class="fa fa-bar-chart"></i>
                                </a>
                                <h4>Responsabilidad</h4>
                                <p class="text-left">
                                    Damos respuestas con calidad a nuestros compromisos, asumimos las consecuencias de nuestras acciones y toma de decisiones, haciéndonos cargos de las situaciones desde un rol protagónico y activo en la gestión.               
                                </p>
                            </div>
                        </div>
                        <!-- end about-details -->
                    </div>
                </div>
                <!-- End Left services -->
                <div class="col-md-4 col-sm-4 col-xs-12">
                    <!-- end col-md-4 -->
                    <div class=" about-move">
                        <div class="services-details">
                            <div class="single-services">
                                <a class="services-icon" href="#">
                                    <i class="fa fa-ticket"></i>
                                </a>
                                <h4>Vocación de Servicio</h4>
                                <p class="text-left">
                                    Actuamos movidos por una energía y un compromiso personal de brindar un servicio con calidad y excelencia, satisfaciendo las necesidades de nuestros clientes.                
                                </p>
                            </div>
                        </div>
                        <!-- end about-details -->
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
