<%@ Page Title="" Language="C#" MasterPageFile="~/Backend/MASTER/Site1.Master" AutoEventWireup="true" CodeBehind="Pais.aspx.cs" Inherits="WebAerolineas.Backend.GUI.Pais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Paises
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Paises
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <div class="row">
        <div class="col-md-4">
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                Agregar nuevo pais
            </button>
        </div>

    </div>
    <div class="row">
        <div class="col-md-8">
            <br />
            <br />
            <div class="col-md-6">
                <asp:TextBox ID="txt_NombrePais" runat="server" CssClass="form-control btn-block" placeholder="Ingrese el nombre del pais" Height="37px" Width="392px"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" CssClass="form-control btn btn-block btn-primary" Height="37px" OnClick="btn_Buscar_Click"/>
            </div>
        </div>
    </div>
    <div class="col-md-12">
        <br />
        <br />
        <asp:GridView ID="gv_Pais" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1127px" DataKeyNames="Id_Pais">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id_Pais" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Pais" />
                <asp:TemplateField HeaderText="Modificar">
                    <ItemTemplate>
                        <a onclick='CargarDatos("<%# Eval("Id_Pais") %>","<%# Eval("Nombre") %>")'>Modificar
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

    <!-- Modal GUARDAR-->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Agregar un pais</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">

                        <div class="form-group col-md-6">
                            <label for="txtid">&nbsp;ID</label>
                            <asp:TextBox ID="txtid" runat="server" CssClass="form-control btn-block" placeholder="ID"></asp:TextBox><br />
                            <label for="txtnombre">&nbsp; Pais</label>
                            <asp:TextBox ID="txtnombre" runat="server" Class="form-control btn-block" placeholder="Nombre"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Salir</button>
                    <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnguardar_Click" />
                </div>
            </div>
        </div>
    </div>
    <!-- Modal ACTUALIZAR-->
    <div class="modal fade" id="exampleModal1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel1">Modificar un pais</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">

                        <div class="form-group col-md-6">
                            <label for="txtIdpais">&nbsp;ID</label>
                            <asp:TextBox ID="txtIdpais" runat="server" CssClass="form-control btn-block" placeholder="ID"></asp:TextBox>
                            <br />
                            <label for="txtNombrepais">&nbsp;Pais</label>
                            <asp:TextBox ID="txtNombrepais" runat="server" Class="form-control btn-block" placeholder="Nombre"></asp:TextBox>
                        </div>

                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Salir</button>
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" OnClick="btnEliminar_Click" />
                </div>
            </div>
        </div>
    </div>


    <script type="text/javascript" src="../js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="../js/bootstrap.min.js"></script>
    <script type="text/javascript" src="../js/bootstrap-notify.min.js"></script>

    <script type="text/javascript">

        var x = $(document);

        x.ready(IniciarEventos);

        function CargarDatos(id, nombre) {

            var x = $("#exampleModal1");
            x.modal();

            x.find(".modal-body .row .col-md-6 #<%= txtIdpais.ClientID %>").val(id);
            x.find(".modal-body .row .col-md-6 #<%= txtNombrepais.ClientID %>").val(nombre);



        }

    </script>
</asp:Content>
