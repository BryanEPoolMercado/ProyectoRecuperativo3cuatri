<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/MasterPage/FrontEnd.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="WebAerolineas.Frontend.GUI.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="nav navbar-nav navbar-right">
                  <li class="active">
                    <a class="page-scroll" href="#home">Home</a>
                  </li>
                  <li>
                    <a class="page-scroll" href="#about">Realizar reservacion</a>
                  </li>
                  <li>
                    <a class="page-scroll" href="#services">Mis reservaciones</a>
                  </li>
                  <li>
                    <a class="page-scroll" href="#team">Mis compras</a>
                  </li>
                  <li>
                    <a class="page-scroll" href="../../Backend/GUI/MenuCatalogos.aspx">Catalogos</a>
                  </li>
                  <li>                    
                </ul>
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
                               
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-1-2 wow slideInUp" data-wow-duration="2s" data-wow-delay=".1s">
                               
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-1-3 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                
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
                               
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-1-2 wow slideInUp" data-wow-duration="2s" data-wow-delay=".1s">
                               
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-1-3 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                                
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
                               
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-1-2 wow slideInUp" data-wow-duration="2s" data-wow-delay=".1s">
                                
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-1-3 hidden-xs wow slideInUp" data-wow-duration="2s" data-wow-delay=".2s">
                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
