<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoDespachoWS.aspx.cs" Inherits="WebServiceDatos.Web.Interfaces.ConexionWS.wsNuevoDespacho" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
h2,h3,p{orphans:3;widows:3}p{margin-top:0;margin-bottom:1rem}*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box}button,input{overflow:visible}button,input,optgroup,select,textarea{margin:0;font-family:inherit;font-size:inherit;line-height:inherit}[type=reset],[type=submit],button,html [type=button]{-webkit-appearance:button;
    height: 33px;
}</style>
</head>
<body>
               
    <p>
    &nbsp;</p>
    <form id="form1" runat="server">
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
    </p>
        <div>
        </div>
    </form>
</body>
</html>
