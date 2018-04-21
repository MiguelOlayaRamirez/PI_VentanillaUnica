<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="PI_PlanillaUnicaJson.Vistas.Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView runat="server" ID="gvwDatos"
                AutoGenerateColums="false" EmpyDataText="sin registros" OnSelectedIndexChanged="gvwDatos_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Codigo Tercero" DataField="CodTercero" />
                    <asp:BoundField HeaderText="Codigo Administrador" DataField="CodAdmon" />
                    <asp:BoundField HeaderText="Fecha Radicado" DataField="Fecha_Radicado" />
                    <asp:BoundField HeaderText="Descripcion" DataField="DescRadicado" />
                    <asp:BoundField HeaderText="Codigo Usuario" DataField="CodUsuario" />
                    <asp:BoundField HeaderText="Codigo Radicado" DataField="CodRadicado" />

                </Columns>
            </asp:GridView>
        </div>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </form>
</body>
</html>
