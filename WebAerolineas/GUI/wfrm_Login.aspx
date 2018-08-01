<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAerolineas.Master" AutoEventWireup="true" CodeBehind="wfrm_Login.aspx.cs" Inherits="WebAerolineas.GUI.wfrm_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">  
  <div class="container-fluid">
	<div class="row">
		<div class="col-md-2">
		</div>
		<div class="col-md-8">
          
  <div class="form">
         
      <br />
      <br />
      <asp:TextBox ID="txt_Correo" runat="server" placeholder="Correo electronico"></asp:TextBox>  
      <asp:TextBox ID="txt_Contrasenia" runat="server" placeholder="Contraseña"></asp:TextBox>         
      <br />
      <asp:Button ID="btn_IniciarSesion" runat="server" Text="Iniciar sesion" backcolor="#3333FF" ForeColor="White" OnClick="btn_IniciarSesion_Click"/>
      <br />
      <p class="message"><a href="#">Registrarse</a></p>
   
  </div>
  </div>
		
		<div class="col-md-2">
		</div>
	</div>
</div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">     
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder6" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="ContentPlaceHolder7" runat="server">
</asp:Content>
