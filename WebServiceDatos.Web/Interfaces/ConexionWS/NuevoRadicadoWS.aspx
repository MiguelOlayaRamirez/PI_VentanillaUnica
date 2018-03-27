
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoRadicadoWS.aspx.cs" Inherits="WebServiceDatos.Web.Interfaces.ConexionWS.NuevoRadicadoWS" %>

        
<head>
    <style type="text/css">
*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box}button,input{overflow:visible}button,input,optgroup,select,textarea{margin:0;font-family:inherit;font-size:inherit;line-height:inherit}[type=reset],[type=submit],button,html [type=button]{-webkit-appearance:button;
    height: 33px;
}</style>
</head>


        
<form id="form1" runat="server">
    <p>
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
                </p>
</form>


        
