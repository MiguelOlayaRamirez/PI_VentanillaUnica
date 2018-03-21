<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="frmDespacho.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmDespacho" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <table class="auto-style18">
        <tr>
            <td style="width:15%" class="auto-style19">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" style="font-weight: 700" /> 
                <asp:Button ID="btnConsulta" runat="server" Text="Consulta" OnClick="btnConsulta_Click" style="font-weight: 700"/>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtIdentifacion" runat="server" Width="99%" Height="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvwDatos" runat="server" Width="100%" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="gvwDatos_RowCommand" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:TemplateField HeaderText="Identificación">
                            <ItemTemplate>
                                <asp:Label ID="lblCodId" runat="server" Text='<%# Bind("ln_CodigoDespacho") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="st_DescripcionDespacho" HeaderText="Descripción" />
                        <asp:BoundField DataField="st_DestinoDespacho" HeaderText="Destino" />
                        <asp:BoundField DataField="st_FechaDespacho" HeaderText="Fecha" />
                        <asp:TemplateField HeaderText="Modificar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ibModificar" runat="server" ImageUrl="~/Imagenes/Edit.gif" CommandName="Modificar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Eliminar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Imagenes/remover.gif" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AllowSorting="True" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <center>
                <asp:Panel ID="pnlAdicionar" runat="server" CssClass="modalPopup" Height="100%" Width="50%" Visible="False">
                    <center>
                    <table style="width:99%">
                        <tr>
                            <td class="col">Código Despacho:</td>
                            <td class="col">Descripción Despacho:</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtCodigoDespachoAdd" runat="server" />
                            </td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtDescripcionDespachoAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Destino:</td>
                            <td class="auto-style1">Fecha:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtDestinoDespachoAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtFechaDestinoAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnOkAdd" runat="server" Text="Guardar" OnClick="btnOkAdd_Click" CssClass="button" />
                                <asp:Button ID="btnCancelarAdd" runat="server" Text="Cancelar" OnClick="btnCancelarAdd_Click" CssClass="button" />
                            </td>
                        </tr>
                    </table>
                    </center>
                </asp:Panel>
                </center>
                <center>
                <asp:Panel ID="pnlModificar" runat="server" CssClass="modalPopup" Height="100%" Width="50%" Visible="False">
                    <table style="width:100%">
                        <tr>
                            <td class="auto-style2">Código Despacho:</td>
                            <td class="auto-style2">Descripción Despacho:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:Label ID="lbCodMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtDescripcionDespachoMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="col">Destino:</td>
                            <td class="col">Fecha:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtDestinoDespachoMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtFechaDestinoMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnOkMod" runat="server" Text="Guardar" OnClick="btnOkMod_Click" CssClass="button" />
                                <asp:Button ID="btnCancelarMod" runat="server" Text="Cancelar" OnClick="btnCancelarMod_Click" CssClass="button" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                </center>
            </td>
        </tr>
    </table>
</asp:Content>


