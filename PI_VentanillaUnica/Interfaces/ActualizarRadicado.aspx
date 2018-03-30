<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="ActualizarRadicado.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.ActualizarRadicado" %>

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
                        Codigo Radicado
                        <asp:TextBox ID="txtCodigoRadicado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Codigo de Tercero
                        <asp:TextBox ID="txtCodigoTercero" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Codigo Administrativo
                        <asp:TextBox ID="txtCodigoAdministrativo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Fecha de Radicado
                        <asp:TextBox ID="txtFechaRadicado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
            </div>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Descripcion
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Codigo de Usuario
                        <asp:TextBox ID="txtCodigoUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <%-- COLUMNA 2 --%>
            <div class="col-md-6">
                &nbsp;
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>

        </div>
    </div>












    <%--    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo Radicado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigoRadicado" runat="server" Width="199px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo de Tercero&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCodigoTercero" runat="server" Width="199px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo Administrativo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigoAdministrativo" runat="server" Width="199px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha de Radicado&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFechaRadicado" runat="server" Width="199px"></asp:TextBox>
    </p>
    <p>--%>
    <%--     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescripcion" runat="server" Width="199px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo de Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigoUsuario" runat="server" Width="199px"></asp:TextBox>
    </p>
    <p>--%>
    <%--       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
        &nbsp;</p>
    <p>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>--%>
</asp:Content>
