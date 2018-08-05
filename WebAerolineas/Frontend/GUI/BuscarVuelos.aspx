<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend/MasterPage/FrontEnd.Master" AutoEventWireup="true" CodeBehind="BuscarVuelos.aspx.cs" Inherits="WebAerolineas.Frontend.GUI.BuscarVuelos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="nav navbar-nav navbar-right">
        <li>
            <a class="page-scroll">Realizar reservacion</a>
        </li>
        <li>
            <a class="page-scroll">Mis reservaciones</a>
        </li>
        <li>
            <a class="page-scroll">Mis compras</a>
        </li>
        <li>
            <a class="page-scroll" href="../../Backend/GUI/MenuCatalogos.aspx">Catalogos</a>
        </li>
        <li>
            <a class="page-scroll">Cerrar sesion</a>
        </li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="bend niceties preview-2">
        <div id="ensign-nivoslider" class="slides">            
            <img src="../Recursos/img/slider/fondo2.jpg" alt="" title="#slider-direction-3" />
        </div>

       

        <!-- direction 3 -->
        <div id="slider-direction-3" class="slider-direction slider-two">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="slider-content">
                            <!-- layer 1 -->
                           
                                <div class="jumbotron">
                                    <div class="container-fluid">
                                        <div class="row">
                                            <div class="col-md-5">
                                                <label for="ddl_origen" class="alignleft">Aeropuerto origen</label>
                                                <asp:DropDownList ID="ddl_origen" runat="server" CssClass="form-control btn-block" Width="330px" placeholder="Aeropuerto origen" DataTextField="Nombre" DataValueField="Id_Aeropuerto"></asp:DropDownList>
                                            </div>
                                            <div class="col-md-5">
                                                <label for="ddl_destino">Aeropuerto destino</label>
                                                <asp:DropDownList ID="ddl_destino" runat="server" CssClass="form-control btn-block" Width="330px" placeholder="Aeropuerto destino" DataTextField="Nombre" DataValueField="Id_Aeropuerto"></asp:DropDownList>
                                            </div>
                                            <div class="col-md-2">
                                                <br />
                                                <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" CssClass="form-control btn btn-block btn-primary" Height="37px" OnClick="btn_Buscar_Click"/>
                                            </div>
                                        </div>
                                       
                                        <div class="col-md-12">
                                            <asp:GridView ID="gv_Vuelos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1127px" DataKeyNames="Id_Vuelo">
                                                <AlternatingRowStyle BackColor="White" />
                                                <Columns>
                                                    <asp:BoundField DataField="Id_Vuelo" HeaderText="ID" />
                                                    <asp:BoundField DataField="Origen" HeaderText="Aeropuerto origen" />
                                                    <asp:BoundField DataField="Destino" HeaderText="Aeropuerto destino"/>
                                                    <asp:BoundField DataField="Hora_Inicio" HeaderText="Hora salida" />
                                                    <asp:BoundField DataField="Hora_Fin" HeaderText="Hora llegada" />                                                                                                
                                                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                                                    <asp:BoundField DataField="Nombre" HeaderText="Aerolinea" />
                                                    <asp:BoundField DataField="NombreModelo" HeaderText="Avion" />   
                                                    <asp:BoundField DataField="NumeroFilas" HeaderText="Filas" />
                                                    <asp:BoundField DataField="NumeroColumnas" HeaderText="Columnas"/>                                                  
                                                    <asp:TemplateField HeaderText="">
                                                        <ItemTemplate>
                                                            <a href="MenuPrincipal.aspx">Seleccionar
                                                            </a>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>

                                                <EditRowStyle BackColor="#2461BF" />
                                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#EFF3FB" />
                                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- layer 2 -->                                                
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<asp:Label ID="label2" runat="server" Text="Label2"></asp:Label>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
