<%@ Page Title="" Language="C#" MasterPageFile="~/Backend/MASTER/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="WebAerolineas.Backend.GUI.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Usuarios
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Usuarios
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div class="row">
        <div class="col-md-4">
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                Agregar nuevo usuario
            </button>
        </div>
    </div>
    <div class="row">
        <div class="col-md-8">
            <br />
            <br />
            <div class="col-md-6">
                <asp:TextBox ID="txt_BuscarUsuario" runat="server" CssClass="form-control btn-block" placeholder="Ingrese el nombre del usuario" Height="37px" Width="392px"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" CssClass="form-control btn btn-block btn-primary" Height="37px" OnClick="btn_Buscar_Click"/>
            </div>
        </div>
    </div>
    <div class="col-md-12">
        <br />
        <br />
        <asp:GridView ID="gv_Usuarios" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1127px" DataKeyNames="Id_Usuario">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id_Usuario" HeaderText="ID" />
                <asp:BoundField DataField="Nombre_perfil" HeaderText="Perfil" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido_pat" HeaderText="Apellido paterno" />
                <asp:BoundField DataField="Apellido_mat" HeaderText="Apellido materno" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha de nacimiento" DataFormatString="{0:dd/MM/yyyy}"/>
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="CodigoPos_Usuario" HeaderText="Codigo postal" />
                <asp:BoundField DataField="Telefono_us" HeaderText="Telefono" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" />
                <asp:BoundField DataField="Contrasenia" HeaderText="Contrasenia" />
                <asp:TemplateField HeaderText="Modificar">
                    <ItemTemplate>
                        <a onclick='CargarDatos("<%# Eval("Id_Usuario") %>","<%# Eval("Nombre_perfil") %>","<%# Eval("Nombre") %>","<%# Eval("Apellido_pat") %>","<%# Eval("Apellido_mat") %>","<%# Eval("Fecha") %>","<%# Eval("Direccion") %>","<%# Eval("CodigoPos_Usuario") %>","<%# Eval("Telefono_us") %>","<%# Eval("Correo") %>","<%# Eval("Contrasenia") %>")'>Modificar
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
                    <h5 class="modal-title" id="exampleModalLabel">Agregar un usuario</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="form-group col-md-6">
                            <label for="txtid">&nbsp;ID</label>
                            <asp:TextBox ID="txtid" runat="server" CssClass="form-control btn-block" placeholder="ID"></asp:TextBox><br />
                            <label for="ddlperfil">&nbsp;Perfil</label>
                            <asp:DropDownList ID="ddlperfil" runat="server" CssClass="form-control btn-block" Width="200px" placeholder="Perfil" DataTextField="Nombre_perfil" DataValueField="Id_Perfil"></asp:DropDownList><br />
                            <label for="txtnombre">&nbsp; Nombre</label>
                            <asp:TextBox ID="txtnombre" runat="server" Class="form-control btn-block" placeholder="Nombre"></asp:TextBox><br />
                            <label for="txtapepat">&nbsp; Apellido paterno</label>
                            <asp:TextBox ID="txtapepat" runat="server" Class="form-control btn-block" placeholder=" Apellido paterno"></asp:TextBox><br />
                            <label for="txtapepat">&nbsp; Apellido materno</label>
                            <asp:TextBox ID="txtapemat" runat="server" Class="form-control btn-block" placeholder=" Apellido materno"></asp:TextBox><br />
                            <label for="dtfechanac">&nbsp; Fecha de nacimiento</label>                            
                            <asp:TextBox ID="dtfechanac" runat="server" type="date" class="form-control btn-block" style="width: 200px"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtdireccion">&nbsp; Direccion</label>
                            <asp:TextBox ID="txtdireccion" runat="server" Class="form-control btn-block" placeholder=" Direccion"></asp:TextBox><br />
                            <label for="txtcp">&nbsp; Codigo postal</label>
                            <asp:TextBox ID="txtcp" runat="server" Class="form-control btn-block" placeholder=" Codigo postal"></asp:TextBox><br />
                            <label for="txttelefono">&nbsp; Telefono</label>
                            <asp:TextBox ID="txttelefono" runat="server" Class="form-control btn-block" placeholder=" Telefono"></asp:TextBox><br />
                            <label for="txtcorreo">&nbsp; Correo</label>
                            <asp:TextBox ID="txtcorreo" runat="server" Class="form-control btn-block" placeholder=" Correo"></asp:TextBox><br />
                            <label for="txtcontra">&nbsp; Contraseña</label>
                            <asp:TextBox ID="txtcontra" runat="server" Class="form-control btn-block" placeholder=" Contraseña"></asp:TextBox><br />
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
                    <h5 class="modal-title" id="exampleModalLabel1">Modificar una ciudad</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="form-group col-md-6">
                            <label for="txt_IdUsuario">&nbsp;ID</label>
                            <asp:TextBox ID="txt_IdUsuario" runat="server" CssClass="form-control btn-block" placeholder="ID"></asp:TextBox><br />
                            <label for="ddl_Perfil">&nbsp;Perfil</label>
                            <asp:DropDownList ID="ddl_Perfil" runat="server" CssClass="form-control btn-block" Width="200px" placeholder="Perfil" DataTextField="Nombre_perfil" DataValueField="Id_Perfil"></asp:DropDownList><br />
                            <label for="txtnombre">&nbsp; Nombre</label>
                            <asp:TextBox ID="txt_NombreUsuario" runat="server" Class="form-control btn-block" placeholder="Nombre"></asp:TextBox><br />
                            <label for="txtapepat">&nbsp; Apellido paterno</label>
                            <asp:TextBox ID="txt_ApellidoPat" runat="server" Class="form-control btn-block" placeholder=" Apellido paterno"></asp:TextBox><br />
                            <label for="txt_ApellidoMat">&nbsp; Apellido materno</label>
                            <asp:TextBox ID="txt_ApellidoMat" runat="server" Class="form-control btn-block" placeholder=" Apellido materno"></asp:TextBox><br />
                            <label for="dt_FechaNacimiento">&nbsp; Fecha de nacimiento</label>
                            <asp:TextBox ID="dt_FechaNacimiento" runat="server" type="date" class="form-control btn-block" style="width: 200px"></asp:TextBox>
                           
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txt_Direccion">&nbsp; Direccion</label>
                            <asp:TextBox ID="txt_Direccion" runat="server" Class="form-control btn-block" placeholder=" Direccion"></asp:TextBox><br />
                            <label for="txtcp">&nbsp; Codigo postal</label>
                            <asp:TextBox ID="txt_CodPost" runat="server" Class="form-control btn-block" placeholder=" Codigo postal"></asp:TextBox><br />
                            <label for="txttelefono">&nbsp; Telefono</label>
                            <asp:TextBox ID="txt_Telefono" runat="server" Class="form-control btn-block" placeholder=" Telefono"></asp:TextBox><br />
                            <label for="txt_Correo">&nbsp; Correo</label>
                            <asp:TextBox ID="txt_Correo" runat="server" Class="form-control btn-block" placeholder=" Correo"></asp:TextBox><br />
                            <label for="txt_Contrasenia">&nbsp; Contraseña</label>
                            <asp:TextBox ID="txt_Contrasenia" runat="server" Class="form-control btn-block" placeholder=" Contraseña"></asp:TextBox><br />
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

        function CargarDatos(id,perfil,nombre,apepat,apemat,fecha,dir,cp,tel,correo,contra)
        {

            var x = $("#exampleModal1");
            x.modal();

            x.find(".modal-body .row .col-md-6 #<%= txt_IdUsuario.ClientID %>").val(id);
            x.find(".modal-body .row .col-md-6 #<%= ddl_Perfil.ClientID %>").val(perfil);
            x.find(".modal-body .row .col-md-6 #<%= txt_NombreUsuario.ClientID %>").val(nombre);
            x.find(".modal-body .row .col-md-6 #<%= txt_ApellidoPat.ClientID %>").val(apepat);
            x.find(".modal-body .row .col-md-6 #<%= txt_ApellidoMat.ClientID %>").val(apemat);
            x.find(".modal-body .row .col-md-6 #<%= dt_FechaNacimiento.ClientID %>").val(fecha);
            x.find(".modal-body .row .col-md-6 #<%= txt_Direccion.ClientID %>").val(dir);
            x.find(".modal-body .row .col-md-6 #<%= txt_CodPost.ClientID %>").val(cp);
            x.find(".modal-body .row .col-md-6 #<%= txt_Telefono.ClientID %>").val(tel);
            x.find(".modal-body .row .col-md-6 #<%= txt_Correo.ClientID %>").val(correo);
            x.find(".modal-body .row .col-md-6 #<%= txt_Contrasenia.ClientID %>").val(contra);
        }

    </script>
</asp:Content>
