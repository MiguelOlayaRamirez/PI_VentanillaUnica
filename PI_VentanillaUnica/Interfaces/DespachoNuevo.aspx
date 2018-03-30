<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="DespachoNuevo.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.Despacho" %>

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
                        Codgio de Despacho
                        <asp:TextBox ID="txtCodigoDespacho" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Descripcion de Despacho
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Destino
                        <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Fecha de Despacho
                        <asp:TextBox ID="txtFechaDespacho" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
            </div>


            <asp:Label ID="lblMensaje" runat="server" Style="color: #FF0000"></asp:Label>
            <div class="form-row">
                <%-- COLUMNA 1 --%>
                <div class="col-md-6">
                    <asp:Button ID="txtGuardar" runat="server" OnClick="txtGuardar_Click" Text="Guardar" CssClass="btn btn-primary" />&nbsp;
                <asp:Button ID="txtCancelar" runat="server" OnClick="txtCancelar_Click" Text="Cancelar" CssClass="btn btn-primary" />
                </div>
            </div>
</asp:Content>
