<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAerolineas.Master" AutoEventWireup="true" CodeBehind="wfrm_Catalogos.aspx.cs" Inherits="WebAerolineas.GUI.wfrm_Catalogos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container main-menu">
                        <div class="row align-items-center d-flex ">
                            <div id="logo">
                                <a href="index.html">
                                <img src="img/logo.png" alt="" title="" /></a>
                            </div>
                            <nav id="nav-menu-container">
                                <ul class="nav-menu">
                                    <li><a href="../GUI/wfrm_MenuPrincipal.aspx">Home</a></li>
                                    <li><a href="index.html">Realizar reservacion</a></li>
                                    <li><a href="index.html">Mis reservaciones</a></li>
                                    <li><a href="../GUI/wfrm_Catalogos.aspx">Catalogos</a></li>                                    
                                </ul>
                            </nav>
                            <!-- #nav-menu-container -->					      		  
					    </div>
                    </div>    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">     
    <div class="container-fluid">
	<div class="row">
		<div class="col-md-2">
			<ul class="nav flex-column nav-pills">
				<li class="nav-item">					
                    <asp:Button ID="Button1" runat="server" Text="Pais" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                   
				</li>
                 <br />
				<li class="nav-item">
					<asp:Button ID="Button2" runat="server" Text="Ciudad" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                    
				</li>
                 <br />
				<li class="nav-item">
					<asp:Button ID="Button3" runat="server" Text="Aeropuerto" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                    
				</li>
                 <br />
                <li class="nav-item">
					<asp:Button ID="Button4" runat="server" Text="Ruta" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                   
				</li>
                 <br />
				<li class="nav-item dropdown ml-md-auto">
					 
					<div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdownMenuLink">
						 <a class="dropdown-item" href="#">Action</a> <a class="dropdown-item" href="#">Another action</a> <a class="dropdown-item" href="#">Something else here</a>
						<div class="dropdown-divider">
						</div> <a class="dropdown-item" href="#">Separated link</a>
					</div>
				</li>
			</ul>
		</div>
		<div class="col-md-2">
<ul class="nav flex-column nav-pills">
				<li class="nav-item">					
                    <asp:Button ID="Button5" runat="server" Text="Aerolinea" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                   
				</li>
                 <br />
				<li class="nav-item">
					<asp:Button ID="Button6" runat="server" Text="Avion" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                    
				</li>
                 <br />
				<li class="nav-item">
					<asp:Button ID="Button7" runat="server" Text="Vuelos" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                    
				</li>
                 <br />
                <li class="nav-item">
					<asp:Button ID="Button8" runat="server" Text="Modelo" Width="153px" BackColor="#0033CC" ForeColor="White"/>
                   
				</li>
                 <br />
				<li class="nav-item dropdown ml-md-auto">
					 
					<div class="dropdown-menu dropdown-menu-right" aria-labelledby="navbarDropdownMenuLink">
						 <a class="dropdown-item" href="#">Action</a> <a class="dropdown-item" href="#">Another action</a> <a class="dropdown-item" href="#">Something else here</a>
						<div class="dropdown-divider">
						</div> <a class="dropdown-item" href="#">Separated link</a>
					</div>
				</li>
			</ul>
		</div>
		<div class="col-md-2">
		</div>
		<div class="col-md-2">
		</div>
		<div class="col-md-2">
		</div>
		<div class="col-md-2">
		</div>
	</div>
</div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder6" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="ContentPlaceHolder7" runat="server">

</asp:Content>
