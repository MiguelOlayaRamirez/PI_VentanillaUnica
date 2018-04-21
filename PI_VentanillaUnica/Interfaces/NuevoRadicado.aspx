<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="NuevoRadicado.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.NuevoRadicado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>
    <br />
    
    <div class="container">
        <div class="mx-auto mt-5">
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        <h1 style='color: #A9E2F3; margin: 0 0 7px'>Radicación</h1>
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
                        Código Tercero
                        <asp:TextBox ID="txtCodigoTercero" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        Código Funcionario
                        <asp:TextBox ID="txtCodigoFuncionario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        Descripción Radicado
                        <asp:TextBox ID="txtDescripcionRadicado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <asp:TextBox ID="txtCodigoUsuario" runat="server" CssClass="form-control" Visible="False" Enabled="false"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-row">
                <%-- COLUMNA 1 --%>
                <div class="col-md-6">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" CssClass="btn btn-primary" />&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" CssClass="btn btn-primary"/>&nbsp;
                </div>
            </div>
</asp:Content>
