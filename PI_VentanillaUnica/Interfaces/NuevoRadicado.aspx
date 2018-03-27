<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="NuevoRadicado.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.NuevoRadicado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
      <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>
                <br />
                <asp:Label ID="lblMensaje" runat="server" style="color: #FF0000"></asp:Label>
                <br />
                <br />
                Codigo de Radicado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigoRadicado" runat="server" />
&nbsp;&nbsp;&nbsp; Fecha de Radicado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtFechaRadicado" runat="server" />
                <br />
                <br />
                Codigo Tercero&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigoTercero" runat="server" />
&nbsp;&nbsp; Codigo Funcionario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigoFuncionario" runat="server" />
                <br />
                <br />
                Dercripcion Radicado&nbsp;
                <asp:TextBox ID="txtDescripcionRadicado" runat="server" />
&nbsp; Codigo Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigoUsuario" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancelar"  />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
