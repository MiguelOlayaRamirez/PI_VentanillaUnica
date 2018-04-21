<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaRaducadoTk.aspx.cs" Inherits="WebServiceDatos.Web.Interfaces.ConexionWS.ConsultaRaducadoTk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        
        <table style="width:100%;">
            <tr>
                <td style="width:50%;">Codigo Radicado</td>
                <td style="width:50%;">
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consulta" OnClick="btnConsultar_Click" />
                </td>
            </tr>
            <tr>
               <td colspan="2">
                   <asp:GridView ID="gvwDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="false" EmptyDataText="No hay Datos" Width="100%">
                      <Columns>
                          <asp:BoundField DataField="CodTercero" HeaderText="Codigo Tercero" />
                          <asp:BoundField DataField="CodAdmon" HeaderText="Codigo Administrador" />
                          <asp:BoundField DataField="Fecha_Radicado" HeaderText="Fecha Radicado" />
                          <asp:BoundField DataField="DescRadicado" HeaderText="Descripcion" />
                          <asp:BoundField DataField="CodUsuario" HeaderText="Codigo Usuario" />
                          <asp:BoundField DataField="CodRadicado" HeaderText="Codigo Radicado" />
                      </Columns>
                       
                       
                       <AlternatingRowStyle BackColor="White" />
                       <EditRowStyle BackColor="#2461BF" />
                       <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                       <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                       <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                       <RowStyle BackColor="#EFF3FB" />
                       <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                       <SortedAscendingCellStyle BackColor="#F5F7FB" />
                       <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                       <SortedDescendingCellStyle BackColor="#E9EBEF" />
                       <SortedDescendingHeaderStyle BackColor="#4870BE" />
                   </asp:GridView>
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
