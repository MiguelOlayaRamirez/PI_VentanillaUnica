<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="frmInformes.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmInformes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">

    <table class="auto-style18">
        <tr>
            <td style="width:40%" class="auto-style19">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" /> 
                <asp:Button ID="btnConsulta" runat="server" Text="Consulta" />
            </td>
            <td>
                <asp:TextBox ID="txtConsulta" runat="server" Width="1085px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Image ID="imRadicado" runat="server" ImageUrl="~/Imagenes/almacenamiento-en-la-nube.png" Height="686px" Width="100%"/>
            </td>
        </tr>
    </table>
</asp:Content>
