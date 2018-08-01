<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAerolineas.Master" AutoEventWireup="true" CodeBehind="wfrm_Aeropuerto.aspx.cs" Inherits="WebAerolineas.GUI.wfrm_Aeropuerto" %>
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

    <asp:Button ID="btn_NuevoAeropuerto" runat="server" Text="Nuevo aeropuerto" Backcolor="#3333FF" ForeColor="White" OnClick="btn_NuevoAeropuerto_Click"/>   
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Aeropuerto"></asp:Label>
    <br />
    <asp:TextBox ID="txt_NombreAeropuerto" runat="server" Width="421px" BorderColor="Black"></asp:TextBox>
    <asp:Button ID="btn_BuscarAeropuerto" runat="server" Text="Buscar" Backcolor="#3333FF" ForeColor="White" OnClick="btn_BuscarAeropuerto_Click"/>      
    <br />       
    <br />       
</div>
<div class="row">
    <div class="col-md-12">
    <asp:GridView ID="gv_Aeropuerto" runat="server" Width="1002px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="Id_Aeropuerto" OnRowCommand="gv_Aeropuerto_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Id_Aeropuerto" HeaderText="Clave" />
            <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" />
            <asp:BoundField DataField="Nombre" HeaderText="Aeropuerto" />
            <asp:ButtonField ButtonType="Button" CommandName="editar" Text="Modificar" />           
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
    <br />
    <br />
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
