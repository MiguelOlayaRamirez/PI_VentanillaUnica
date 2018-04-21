<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="Radicados.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.Radicados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">

    <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>



    <div class="form-row">
        <%-- COLUMNA 1 --%>
        <div class="col-md-6">
            <asp:TextBox ID="txtCodigoRadicado" runat="server" Height="26px" Width="100%"></asp:TextBox>&nbsp;&nbsp;
            <ajax:AutoCompleteExtender ID="aceBusquedaRadicado" runat="server"
                ServicePath="~/Ventanilla_Unica_Ws.asmx"
                            ServiceMethod="dsConsultaRadicado"
                            MinimumPrefixLength="1"
                            CompletionInterval="100"
                            EnableCaching="false"
                            CompletionSetCount="10"
                            FirstRowSelected="false"
                            UseContextKey="true"
                            TargetControlID="txtCodigoRadicado">
            </ajax:AutoCompleteExtender>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:Button ID="btnConsulta" runat="server" OnClick="btnConsulta_Click" Text="CONSULTA" CssClass="btn btn-primary" />&nbsp;
        </div>
    </div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CodRadicado" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Width="1024px">
        <Columns>
            <asp:BoundField DataField="CodRadicado" HeaderText="CodRadicado" InsertVisible="False" ReadOnly="True" SortExpression="CodRadicado" />
            <asp:BoundField DataField="CodTercero" HeaderText="CodTercero" SortExpression="CodTercero" />
            <asp:BoundField DataField="CodAdmon" HeaderText="CodAdmon" SortExpression="CodAdmon" />
            <asp:BoundField DataField="Fecha_Radicado" HeaderText="Fecha_Radicado" SortExpression="Fecha_Radicado" />
            <asp:BoundField DataField="DescRadicado" HeaderText="DescRadicado" SortExpression="DescRadicado" />
            <asp:BoundField DataField="CodUsuario" HeaderText="CodUsuario" SortExpression="CodUsuario" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Ventanilla UnicaConnectionString4 %>" SelectCommand="SELECT * FROM [Radicado] WHERE ([CodRadicado] = @CodRadicado)">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtCodigoRadicado" Name="CodRadicado" PropertyName="Text" Type="Int64" />
        </SelectParameters>
    </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>
