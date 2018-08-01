<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAerolineas.Master" AutoEventWireup="true" CodeBehind="wfrm_ModeloEdit.aspx.cs" Inherits="WebAerolineas.GUI.wfrm_ModeloEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="landing-page"><<div class="form-appointment"><div class="wpcf7" id="wpcf7-f560-p590-o1"><form action="/landing-page-template-do-not-delete/#wpcf7-f560-p590-o1" method="post" class="wpcf7-form" novalidate="novalidate" _lpchecked="1">
<div style="display: none;">
<input type="hidden" name="_wpcf7" value="300">
<input type="hidden" name="_wpcf7_version" value="3.5">
<input type="hidden" name="_wpcf7_locale" value="">
<input type="hidden" name="_wpcf7_unit_tag" value="wpcf7-f560-p590-o1">
<input type="hidden" name="_wpnonce" value="dbb28877d5">
</div>
<div class="group">
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Número de filas"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Número de columnas"></asp:Label>
    <br />
    <asp:TextBox ID="txt_ClaveModelo" runat="server" Width="107px" BorderColor="Black" Enabled="False"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_NumeroFilas" runat="server" Width="107px" BorderColor="Black"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_NumeroColumnas" runat="server" Width="107px" BorderColor="Black"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Modelo"></asp:Label>
    <br />
    <asp:TextBox ID="txt_NombreModelo" runat="server" Width="421px" BorderColor="Black"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" Backcolor="#3333FF" ForeColor="White" OnClick="btn_Guardar_Click"/>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_GuardarNext" runat="server" Text="Guardar y seguir capturando" Backcolor="#3333FF" ForeColor="White" Width="319px" OnClick="btn_GuardarNext_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" Backcolor="Red" ForeColor="White" OnClick="btn_Eliminar_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_Cancelar" runat="server" Text="Cancelar" Backcolor="#3333FF" ForeColor="White" OnClick="btn_Cancelar_Click"/>
    <br />       
    <br />      
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
