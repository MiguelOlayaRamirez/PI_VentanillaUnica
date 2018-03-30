<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="WebServiceDatos.Web.Interfaces.ConexionWS.NuevoUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
h2,h3,p{orphans:3;widows:3}p{margin-top:0;margin-bottom:1rem}*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box}button,input{overflow:visible}button,input,optgroup,select,textarea{margin:0;font-family:inherit;font-size:inherit;line-height:inherit}[type=reset],[type=submit],button,html [type=button]{-webkit-appearance:button;
    height: 33px;
}
        .auto-style3 {
            width: 100%;
            border: 4px solid #008080;
            background-color: #99CCFF;
        }
        .auto-style6 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style4 {
            height: 34px;
        }
        .auto-style5 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
&nbsp;<table class="auto-style3">
                    <tr>
                        <td ><strong>Código</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCodigoUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td ><strong>Nombres</strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtNombreUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class=><strong>Apellidos</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtApellidosUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class=><strong >Cargo</strong></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCargoUsuario" runat="server" Height="20px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <center style="color: #FF0000">
                                <asp:Button ID="txtGuardar" runat="server" OnClick="txtGuardar_Click" Text="GUARDAR" />
                                <strong>
                                <br />
                                <br />
                                </strong>
                                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                            </center>
                        </td>
                    </tr>
                </table>
    </p>
        <div>
        </div>
    </form>
</body>
</html>
