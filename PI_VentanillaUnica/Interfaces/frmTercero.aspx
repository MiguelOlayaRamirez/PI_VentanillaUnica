<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="frmTercero.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.frmTercero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 25%;
            height: 27px;
        }
        .auto-style3 {
            width: 25%;
            height: 23px;
        }
        .button {
            font-weight: 700;
            font-size: medium;
        }
        .auto-style4 {
            width: 2176px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <table class="auto-style18">
        <tr>
            <td style="width:15%" class="auto-style19">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" style="font-weight: 700; font-size: medium" />
                <asp:Button ID="btnConsulta" runat="server" Text="Consulta" OnClick="btnConsulta_Click" style="font-weight: 700; font-size: medium"/>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtIdentifacion" runat="server" Width="85%" Height="20px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvwDatos" runat="server" Width="100%" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="gvwDatos_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Código Tercero">
                            <ItemTemplate>
                                <asp:Label ID="lblCodId" runat="server" Text='<%# Bind("ln_CodigoTercero") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="st_TelefonoTercero" HeaderText="Teléfono" />
                        <asp:BoundField DataField="st_CorreoTercero" HeaderText="E-mail" />
                        <asp:BoundField DataField="st_DescripcionTercero" HeaderText="Descripción" />
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
                            <td class="col">Código Tercero:</td>
                            <td class="col">Teléfono Tercero:</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:TextBox ID="txtCodigoTerceroAdd" runat="server" />
                            </td>
                            <td class="auto-style3">
                                <asp:TextBox ID="txtTelefonoTerceroAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">E-mail Tercero:</td>
                            <td class="auto-style3">Descripción Tercero:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtCorreoTerceroAdd" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtDescripcionTerceroAdd" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <center>
                                <asp:Button ID="btnOkAdd" runat="server" Text="Guardar" style="font-weight: 700; font-size: medium" OnClick="btnOkAdd_Click"/>
                                <asp:Button ID="btnCancelarAdd" runat="server" Text="Cancelar" style="font-weight: 700; font-size: medium" OnClick="btnCancelarAdd_Click"/>
                                </center>
                            </td>
                        </tr>
                    </table>
                    </center>
                </asp:Panel>
                </center>
                <center>
                <asp:Panel ID="pnlModificar" runat="server" Visible ="false" CssClass="modalPopup" Height="100%" Width="50%">
                    <center>
                    <table style="width:100%">
                        <tr>
                            <td class="auto-style2">Código Tercero:</td>
                            <td class="auto-style2">Teléfono Tercero:</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="lbCodMod" runat="server" />
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox ID="txtTelefonoTerceroMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="col">E-mail Tercero:</td>
                            <td class="col">Descripción Tercero:</td>
                        </tr>
                        <tr>
                            <td class="col">
                                <asp:TextBox ID="txtCorreoTerceroMod" runat="server" />
                            </td>
                            <td class="col">
                                <asp:TextBox ID="txtDescripcionTerceroMod" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <center>
                                <asp:Button ID="btnOkMod" runat="server" Text="Guardar" CssClass="button" OnClick="btnOkMod_Click" />
                                <asp:Button ID="btnCancelarMod" runat="server" Text="Cancelar" CssClass="button" OnClick="btnCancelarMod_Click" />
                                </center>
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
