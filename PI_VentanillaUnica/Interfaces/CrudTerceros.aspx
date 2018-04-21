<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="CrudTerceros.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.CrudTerceros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>
        <div class="container">
        <div class="mx-auto mt-5">
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        Usuario en linea
                        <asp:Label ID="lblUsuario" runat="server" Style="color: #9966FF"></asp:Label>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-6">
                        Codigo Tercer
                        <asp:TextBox ID="txtCodigoTercero" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajax:AutoCompleteExtender ID="acexIdentificacionTercero" runat="server"
                            ServicePath="~/Ventanilla_Unica_Ws.asmx"
                            ServiceMethod="dsConsultaTerceros"
                            MinimumPrefixLength="2"
                            CompletionInterval="100"
                            EnableCaching="false"
                            CompletionSetCount="10"
                            FirstRowSelected="false"
                            UseContextKey="true"
                            TargetControlID="txtCodigoTercero">                    
                        </ajax:AutoCompleteExtender>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </div>
                </div>
            </div>
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-4">
                        Telefono
                        <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <%-- COLUMNA 2 --%>
                    <div class="col-md-4">
                       Email
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                      Nombre Completo
                        <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
        <div class="form-row">
            <%-- COLUMNA 1 --%>
            <div class="col-md-6">
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" CssClass="btn btn-primary" />&nbsp;
                    <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" CssClass="btn btn-primary" />&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" CssClass="btn btn-primary" />&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" CssClass="btn btn-primary" />



                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>


    <asp:GridView ID="gvwDatos" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" EmptyDataText="No se encontro registro">
        <Columns>
            <asp:BoundField HeaderText="Codigo" DataField="CodTercero" />
            <asp:BoundField HeaderText="Telefono" DataField="TelTercero" />
            <asp:BoundField HeaderText="Email" DataField="EmailTercero" />
            <asp:BoundField HeaderText="Nombre Completo" DataField="DescTercero" />
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
</asp:Content>
