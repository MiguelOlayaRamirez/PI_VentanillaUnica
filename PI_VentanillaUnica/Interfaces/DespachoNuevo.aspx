<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="DespachoNuevo.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.Despacho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
        <link href="../CSS/sweetalert.css" rel="stylesheet" />
        <script src="../js/sweetalert.min.js" type="text/javascript"></script>
               
    <p>
    &nbsp;</p>
<p>
    &nbsp;Codgio de Despacho&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCodigoDespacho" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion de Despacho&nbsp;&nbsp;
    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Destino&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtDestino" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha de Despacho&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtFechaDespacho" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblMensaje" runat="server" style="color: #FF0000"></asp:Label>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="txtGuardar" runat="server" OnClick="txtGuardar_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="txtCancelar" runat="server" OnClick="txtCancelar_Click" Text="Cancelar" />
</p>
</asp:Content>
