<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="frmRadicado.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmRadicado" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
      <table class="auto-style18">
        <tr>
            <td style="width:15%" class="auto-style19">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" style="font-weight: 700" /> 
                <br />
                <asp:Button ID="btnConsulta" runat="server" Text="Consulta" OnClick="btnConsulta_Click" style="font-weight: 700"/>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtIdentifacion" runat="server" Width="84%" Height="20px" OnTextChanged="txtIdentifacion_TextChanged"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvwDatos" runat="server" Width="100%" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="gvwDatos_RowCommand" OnSelectedIndexChanged="gvwDatos_SelectedIndexChanged" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:TemplateField HeaderText="Código Radicado">
                            <ItemTemplate>
                                <asp:Label ID="lblCodId" runat="server" Text='<%# Bind("ln_CodigoRadicado") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ln_CodTerceroRadicado" HeaderText="Código Tercero" />
                        <asp:BoundField DataField="ln_CodAdmonRadicado" HeaderText="Código Funcionario" />
                        <asp:BoundField DataField="st_FechaRadicado" HeaderText="Fecha de Radicación" />
                        <asp:BoundField DataField="st_DescripcionRadicado" HeaderText="Descripción" />
                        <asp:BoundField DataField="ln_CodUsuarioRadicado" HeaderText="Código Usuario" />
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
                <asp:Panel ID="pnlAdicionar" runat="server" CssClass="modalPopup" Height="100%" Width="50%" Visible="False">
                    <center>
                    <table style="width:99%">
                        <tr>
                            <td class="col">Código Radicado:</td>
                            <td class="col">Código Tercero:</td>
                            <td class="col">Código Funcionario:</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtCodigoRadicadoAdd" runat="server" />
                            </td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtCódigoTerceroAdd" runat="server" />
                            </td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtCódigoFuncionarioAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Fecha Radicado:</td>
                            <td class="auto-style1">Descripción Radicado:</td>
                            <td class="auto-style1">Código Usuario:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtFechaRadicadoAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtDescripcionRadicadoAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCodigoUsuarioAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
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
                            <td class="col">Código Radicado:</td>
                            <td class="col">Código Tercero:</td>
                            <td class="col">Código Funcionario:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:Label ID="lbCodMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCódigoTerceroMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCódigoFuncionarioMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Fecha Radicado:</td>
                            <td class="auto-style1">Descripción Radicado:</td>
                            <td class="auto-style1">Código Usuario:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtFechaRadicadoMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtDescripcionRadicadoMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtCodigoUsuarioMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
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




