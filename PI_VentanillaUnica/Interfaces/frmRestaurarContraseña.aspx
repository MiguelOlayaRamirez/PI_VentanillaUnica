<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRestaurarContraseña.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmRestaurarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
        <center>
            <asp:Image ID="imLogin" runat="server" ImageUrl="~/Imagenes/Ventanilla única.jpg" Height="200px" Width="100%" />
            <table class="auto-style1">
        <tr>
            <td class="auto-style1" style="width:20%"><strong>Recupera tu cuenta :</strong></td>
            <td class="auto-style2">
                <asp:TextBox ID="txtUsuario" runat="server" Width="80%" BackColor="White" ForeColor="Silver"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style1">
                <p style="text-align: center">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" BorderStyle="Solid" OnClick="btnEnviar_Click" style="font-weight: 700; font-style: italic; font-size: large; color: #0000FF; text-align: center; background-color: #FFFFFF" Width="107px" />
                &nbsp;</p>
            </td>
        </tr>
            <tr>
               <td colspan="2">
                  <center><asp:TextBox ID="TextBox1" runat="server" Enabled="False" Height="22px" BackColor="White"></asp:TextBox></center> 
               </td>
            </tr>
            <tr>
               <td colspan="1">
                   <asp:Button ID="btnVolver" runat="server" Text="Volver" BorderStyle="Solid" style="font-weight: 700; font-style: italic; font-size: large; color: #0000FF; text-align: center; background-color: #FFFFFF" Width="107px" PostBackUrl="~/Interfaces/Login.aspx"/>
               </td>
            </tr>
       </table></center>
    </div>
    </form>
</body>
</html>
