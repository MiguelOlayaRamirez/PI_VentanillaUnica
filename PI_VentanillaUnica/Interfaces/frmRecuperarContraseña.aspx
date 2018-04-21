<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRecuperarContraseña.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmRestaurarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperar Password</title>
    <style type="text/css">
        .form-control {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <center><div class="container">
          <asp:Image ID="imLogin" runat="server" ImageUrl="~/Imagenes/Ventanilla única.jpg" Height="200px" Width="100%" />
              <div class="card card-login" mx-auto mt-5>
                <div class="card-header">Recuperar Password</div>
                    <div class="card-body">
                     <div class="text-center mt-4 mb-5">
                        <h4>Olvidó su password?</h4>
                        <p>Ingrese su dirección de correo electrónico y nosotros enviaremos las instrucciones para la recuperación de su password.</p>
                     </div>
                    <div class="form-group">
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" Width="255px"></asp:TextBox>
                    </div>
                        <br/>
                        <br/>
                    <asp:Button runat="server" ID="btnRecuperar" CssClass="btn btn-primary btn-block" Text="Recuperar Password" OnClick="btnRecuperar_Click" style="font-weight: 700; font-style: italic; font-size: large; color: #0000FF; text-align: center; background-color: #FFFFFF"/>
                    <div class="text-center">
                        <a class="d-block small mt-3" href="Login.aspx">Login</a>
                    </div>
                </div>
            </div>
        </div></center>
    </form>
</body>
</html>
