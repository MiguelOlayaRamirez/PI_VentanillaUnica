<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="ActualizarDespacho.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.ActualizarDespacho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>

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
                        Codigo de Despacho
                        <asp:TextBox ID="txtCodigoDespacho" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Descripcion del Despacho
                        <asp:TextBox ID="txtDescripcionDespacho" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Destino Despacho
                        <asp:TextBox ID="txtDestinoDespacho" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Fecha Despacho
                        <asp:TextBox ID="txtFechaDespacho" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        &nbsp;
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        <asp:Button ID="btnActualizarDespacho" runat="server" OnClick="btnActualizarDespacho_Click" Text="Actualizar" CssClass="btn btn-primary" />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cancelar" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
