<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 42%;
        }
        .auto-style2 {
            width: 213px;
        }
        .auto-style3 {
            height: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:Image ID="imLogin" runat="server" ImageUrl="~/Imagenes/Ventanilla única.jpg" Height="200px" Width="100%" />
            <table class="auto-style1">
        <tr>
            <td class="auto-style1" style="width:20%"><strong>Usuario :</strong></td>
            <td class="auto-style2">
                <asp:TextBox ID="txtUsuario" runat="server" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width:20%"><strong>Password :</strong></td>
            <td class="auto-style2">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style3">
                <p style="text-align: center">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" BorderStyle="Solid" OnClick="btnIngresar_Click" style="font-weight: 700; font-style: italic; font-size: large; color: #0000FF; text-align: center; background-color: #FFFFFF" Width="107px" />
                &nbsp;<asp:Button ID="btnRegistro" runat="server" Text="Registrarse" BorderStyle="Solid" style="font-weight: 700; font-style: italic; font-size: large; color: #0000FF; background-color: #FFFFFF" PostBackUrl="~/Interfaces/frmUsuarios.aspx"/>
                </p>
                <p style="text-align: center">
                    <asp:CheckBox ID="chkRecordar" runat="server" Text="Recordar Usuario" />
                </p>
            </td>
        </tr>
            <tr>
            <td colspan="2">
                <center><asp:Label ID="lbMensaje" runat="server" style="font-weight: 700; color: #CC3300; text-align: center;"></asp:Label></center>
            </td>
            </tr>
       </table></center>
    </div>
    </form>
</body>
</html>