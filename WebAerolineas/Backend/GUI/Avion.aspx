<%@ Page Title="" Language="C#" MasterPageFile="~/Backend/MASTER/Site1.Master" AutoEventWireup="true" CodeBehind="Avion.aspx.cs" Inherits="WebAerolineas.Backend.GUI.Avion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Aviones
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Aviones
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div class="row">
        <div class="col-md-4">
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                Agregar nuevo avion
            </button>
        </div>

    </div>
    <div class="row">
        <div class="col-md-8">
            <br />
            <br />
            <div class="col-md-6">
                <asp:TextBox ID="txt_BuscarAvion" runat="server" CssClass="form-control btn-block" placeholder="Ingrese el nombre del modelo de avion" Height="37px" Width="392px"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" CssClass="form-control btn btn-block btn-primary" Height="37px" OnClick="btn_Buscar_Click"/>
            </div>
        </div>
    </div>
    <div class="col-md-12">
        <br />
        <br />
        <asp:GridView ID="gv_Avion" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1127px" DataKeyNames="Id_Avion">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id_Avion" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Aerolinea" />
                <asp:BoundField DataField="NombreModelo" HeaderText="Modelo" />
                <asp:BoundField DataField="NumeroPasajeros" HeaderText="Número de pasajeros" />
                <asp:TemplateField HeaderText="Modificar">
                    <ItemTemplate>
                        <a onclick='CargarDatos("<%# Eval("Id_Avion") %>","<%# Eval("Nombre") %>","<%# Eval("NombreModelo") %>","<%# Eval("NumeroPasajeros") %>")'>Modificar
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
                    <h5 class="modal-title" id="exampleModalLabel">Agregar un avion</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">

                        <div class="form-group col-md-6">
                            <label for="txtid">&nbsp;ID</label>
                            <asp:TextBox ID="txtid" runat="server" CssClass="form-control btn-block" placeholder="ID"></asp:TextBox><br />
                            <label for="ddlaerolinea">&nbsp; Aerolinea</label>
                            <asp:DropDownList ID="ddlaerolinea" runat="server" CssClass="form-control btn-block" Width="200px" placeholder="Aerolinea" DataTextField="Nombre" DataValueField="Id_Aerolinea"></asp:DropDownList><br />
                            <label for="ddlmodelo">&nbsp; Modelo</label>
                            <asp:DropDownList ID="ddlmodelo" runat="server" CssClass="form-control btn-block" Width="200px" placeholder="Modelo" DataTextField="NombreModelo" DataValueField="IdModelo"></asp:DropDownList><br />
                            <label for="txtnumpasajeros">&nbsp; Número de pasajeros</label>
                            <asp:TextBox ID="txtnumpasajeros" runat="server" Class="form-control btn-block" placeholder="Número de pasajeros"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Salir</button>
                    <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btn_Guardar_Click"/>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal ACTUALIZAR-->
    <div class="modal fade" id="exampleModal1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel1">Modificar un avion</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">

                        <div class="form-group col-md-6">
                            <label for="txt_IdAvion">&nbsp;ID</label>
                            <asp:TextBox ID="txt_IdAvion" runat="server" CssClass="form-control btn-block" placeholder="ID"></asp:TextBox><br />
                            <label for="ddl_Aerolinea">&nbsp; Aerolinea</label>
                            <asp:DropDownList ID="ddl_Aerolinea" runat="server" CssClass="form-control btn-block" Width="200px" placeholder="Aerolinea" DataTextField="Nombre" DataValueField="Id_Aerolinea"></asp:DropDownList><br />
                            <label for="ddl_Modelo">&nbsp; Modelo</label>
                            <asp:DropDownList ID="ddl_Modelo" runat="server" CssClass="form-control btn-block" Width="200px" placeholder="Modelo" DataTextField="NombreModelo" DataValueField="IdModelo"></asp:DropDownList><br />
                            <label for="txt_NumPasajeros">&nbsp; Número de pasajeros</label>
                            <asp:TextBox ID="txt_NumPasajeros" runat="server" Class="form-control btn-block" placeholder="Número de pasajeros"></asp:TextBox>
                        </div>

                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Salir</button>
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click"/>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" OnClick="btnEliminar_Click"/>
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

        function CargarDatos(id, aerolinea, modelo, numasi)
        {

            var x = $("#exampleModal1");
            x.modal();

            x.find(".modal-body .row .col-md-6 #<%= txt_IdAvion.ClientID %>").val(id);
            x.find(".modal-body .row .col-md-6 #<%= ddl_Aerolinea.ClientID %>").val(nombre);
            x.find(".modal-body .row .col-md-6 #<%= ddl_Modelo.ClientID %>").val(modelo);
            x.find(".modal-body .row .col-md-6 #<%= txt_NumPasajeros.ClientID %>").val(numasi);

        }

    </script>
</asp:Content>
