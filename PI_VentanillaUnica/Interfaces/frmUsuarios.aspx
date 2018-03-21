<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuarios.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .button {
            font-weight: 700;
            color: #3366FF;
            font-size: large;
            background-color: #FFFFFF;
        }
        .auto-style3 {
            width: 100%;
            border: 4px solid #008080;
            background-color: #99CCFF;
        }
        .auto-style4 {
            height: 34px;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style7 {
            font-size: xx-large;
        }
        .auto-style8 {
            width: 100%;
        }
        </style>
</head>
<body style="height: 613px">
    <form id="frmUsuarios" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Ventanilla única.jpg" Height="200px" Width="100%" />
        </div>
        <div>
            <center style="background-color: #33CCFF"><asp:Label ID="lblRegistroUsuario" runat="server" Text="REGISTRO USUARIO" style="font-weight: 700; font-size: x-large; color: #000000; background-color: #33CCFF"></asp:Label></center>
        </div>
        <div>
            <asp:Panel ID="pnlSeparador" runat="server">
                <table class="auto-style8">
                    <tr>
                        <td style="width:97%">
                            <asp:Button ID="btnAnterior" runat="server" Text="Anterior" style="font-size: medium; font-weight: 700; color: #3333FF" PostBackUrl="~/Interfaces/Login.aspx"/>
                        </td>
                        <td style="width:3%">
                            <asp:Button ID="btnSalir" runat="server" style="font-weight: 700; font-size: medium; color: #CC0000;" Text="Salir" PostBackUrl="~/Interfaces/frmSalida.aspx"/>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <center>
        <asp:Panel ID="pnlAdicionar" runat="server" Height="100%" Width="100%">
            <asp:Panel ID="pnlRegistroUsuario" runat="server" Width="237px" BackImageUrl="~/Imagenes/registro.png">
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style6"><strong>Código</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCodigoUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Nombres</strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtNombreUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Apellidos</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtApellidosUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><strong style="font-size: x-large">Cargo</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCargoUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <center style="color: #FF0000">
                                <strong>
                                <asp:ImageButton ID="imaOkUsuario" runat="server" ImageUrl="~/Imagenes/check_mark_save.png" OnClick="imaOkUsuario_Click"/>
                                <asp:ImageButton ID="imaCancelUsuario" runat="server" ImageUrl="~/Imagenes/close_check.png" OnClick="imaCancelUsuario_Click" PostBackUrl="~/Interfaces/Login.aspx"/>
                                <br />
                                <br />
                                </strong>
                                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                            </center>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </asp:Panel>
        </center>
    </form>
</body>
</html>
