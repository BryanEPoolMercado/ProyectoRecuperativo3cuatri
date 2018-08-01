<%@ Page Title="" Language="C#" MasterPageFile="~/Backend/MASTER/Site1.Master" AutoEventWireup="true" CodeBehind="MenuCatalogos.aspx.cs" Inherits="WebAerolineas.Backend.GUI.MenuCatalogos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Catalogos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Catalogos
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-sm-6 col-xs-12">
                <div class="section-headline text-center">
                    <h2>Bienvenido</h2>
                </div>
            </div>
        </div>
        <div class="row">

            <!-- single-well start-->

            <!-- single-well end-->
            <div class="col-md-6 col-sm-6 col-xs-12">
                <div class="well-middle">
                    <div class="single-well">
                        <a href="#">
                            <h4 class="sec-head">En este apartado usted tendra acceso a las siguientes funciones:</h4>
                            <br />
                        </a>

                        <ul>
                            <li class="text-left">
                                <i class="fa fa-check"></i>Agregar Registros al sistema, el cual se vera reflejado para todo usuario que tenga el acceso
                                   </li>
                            <br />
                            <li class="text-left">
                                <i class="fa fa-check"></i>Modificar la informacion de los registros que ya se encuentran en el sistema
                                 </li>
                            <br />
                            <li class="text-left">
                                <i class="fa fa-check"></i>Eliminar los regitros actuales del sistema
                                 </li>
                            <br />
                            <li class="text-left">
                                <i class="fa fa-check"></i>Realizar consultas en cada uno de los catalogos
                                 </li>
                            <br />
                        </ul>
                        <p>
                            El acceso a este apartado del sistema es unico para el personal autorizado, de igual manaera los cambios efectuados en cada uno de los catalogos sera realizado bajo responsabilidad del personal en acceso o del area correspondiente. todo esto bajo los lineamientos de la compañia Aerolineas AirFly S.A de C.V.             
                        </p>
                    </div>
                </div>
            </div>
            <!-- End col-->
        </div>
    </div>
</asp:Content>
