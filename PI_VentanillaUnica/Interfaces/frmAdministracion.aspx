<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="frmAdministracion.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmAdministracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 25%;
            height: 23px;
        }
        .button {
            font-weight: 700;
            font-size: medium;
        }
        .auto-style3 {
            width: 1955px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style18">
        <tr>
            <td style="width:15%" class="auto-style19">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" style="font-weight: 700; font-size: medium" /> 
                <asp:Button ID="btnConsulta" runat="server" Text="Consulta" OnClick="btnConsulta_Click" style="font-weight: 700; font-size: medium"/>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtIdentifacion" runat="server" Width="99%" Height="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvwDatos" runat="server" Width="100%" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="gvwDatos_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Código Colaborador">
                            <ItemTemplate>
                                <asp:Label ID="lblCodId" runat="server" Text='<%# Bind("ln_CodigoAdmon") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="st_NombreAdmon" HeaderText="Nombre Colaborador" />
                        <asp:BoundField DataField="st_ApellidoAdmon" HeaderText="Apellido Colaborador" />
                        <asp:BoundField DataField="st_CargoAdmon" HeaderText="Cargo" />
                        <asp:BoundField DataField="st_AreaAdmon" HeaderText="Área" />
                        <asp:BoundField DataField="ln_CodDespachoAdmon" HeaderText="Código Despacho" />
                        <asp:BoundField DataField="ln_CodProcesoAdmon" HeaderText="Código Proceso" />
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
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <center>
                <asp:Panel ID="pnlAdicionar" runat="server" Visible="false" CssClass="modalPopup" Height="100%" Width="50%">
                    <center>
                    <table style="width:99%">
                        <tr>
                            <td class="col">Código Colaborador:</td>
                            <td class="col">Nombre Colaborador:</td>
                            <td class="col">Apellido Colaborador:</td>
                            <td class="col">Cargo Colaborador:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtCodigoAdmonAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtNombreAdmonAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtApellidoAdmonAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCargoAdmonAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="col">Área Colaborador:</td>
                            <td class="col">Código Despacho:</td>
                            <td class="col">Código Proceso:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtAreaAdmonAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCodDespachoAdmonAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCodProcesoAdmonAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <center>
                                <asp:Button ID="btnOkAdd" runat="server" Text="Guardar" OnClick="btnOkAdd_Click" CssClass="button" />
                                <asp:Button ID="btnCancelarAdd" runat="server" Text="Cancelar" OnClick="btnCancelarAdd_Click" CssClass="button" />
                                </center>
                            </td>
                        </tr>
                    </table>
                    </center>
                </asp:Panel>
                </center>
                <center>
                <asp:Panel ID="pnlModificar" runat="server" CssClass="modalPopup" Height="100%" Width="50%">
                    <center>
                    <table style="width:100%">
                        <tr>
                            <td class="auto-style2">Código Colaborador:</td>
                            <td class="auto-style2">Nombre Colaborador:</td>
                            <td class="auto-style2">Apellido Colaborador:</td>
                            <td class="auto-style2">Cargo Colaborador:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:Label ID="lbCodMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtNombreAdmonMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtApellidoAdmonMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCargoAdmonMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="col">Área Colaborador:</td>
                            <td class="col">Código Despacho:</td>
                            <td class="col">Código Proceso:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtAreaAdmonMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCodDespachoAdmonbMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCodProcesoAdmonMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Button ID="btnOkMod" runat="server" Text="Guardar" OnClick="btnOkMod_Click" CssClass="button" />
                                <asp:Button ID="btnCancelarMod" runat="server" Text="Cancelar" OnClick="btnCancelarMod_Click" CssClass="button" />
                            </td>
                        </tr>
                    </table>
                    </center>
                </asp:Panel>
                </center>
            </td>
        </tr>
    </table>
</asp:Content>
