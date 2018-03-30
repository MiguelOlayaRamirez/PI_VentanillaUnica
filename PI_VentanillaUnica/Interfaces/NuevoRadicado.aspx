<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="NuevoRadicado.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.NuevoRadicado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>
    <br />
    <asp:Label ID="lblMensaje" runat="server" Style="color: #FF0000"></asp:Label>


    <div class="container">
        <div class="mx-auto mt-5">
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Usuario en linea
                        <asp:Label ID="lblUsuario" runat="server" Style="color: #9966FF"></asp:Label>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Codigo de Radicado
                        <asp:TextBox ID="txtCodigoRadicado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Fecha de Radicado
                        <asp:TextBox ID="txtFechaRadicado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Codigo Tercero
                        <asp:TextBox ID="txtCodigoTercero" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        Codigo Funcionario
                        <asp:TextBox ID="txtCodigoFuncionario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        Dercripcion Radicado
                        <asp:TextBox ID="txtDescripcionRadicado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        Codigo Usuario
                        <asp:TextBox ID="txtCodigoUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-row">
                <%-- COLUMNA 1 --%>
                <div class="col-md-6">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" CssClass="btn btn-primary" />&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
                </div>
            </div>
</asp:Content>
