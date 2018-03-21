<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSalida.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmSalida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
            color: #0000FF;
        }
        .auto-style2 {
            text-decoration: underline;
            font-size: large;
            color: #0000CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Ventanilla única.jpg" Height="200px" Width="100%" />
    </div>
    <div>
        <asp:Panel ID="pnlSeparador" runat="server">
            <table class="auto-style8">
                <tr>
                    <td style="width: 81%; background-color: #FFFFFF;">
                        <asp:Button ID="btnAnterior" runat="server" Text="Anterior" Style="font-size: medium; font-weight: 700; color: #3333FF" PostBackUrl="~/Interfaces/frmUsuarios.aspx" />
                    </td>
                    <td style="width: 19%">
                        <em><strong><span class="auto-style1">Contacto :</span></strong></em> <span class="auto-style2"><em>advance@advance.org</em></span></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    <div>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/TE ESPERAMOS.jpg" Height="624px" Width="100%" />
    </div>
    </form>
</body>
</html>
