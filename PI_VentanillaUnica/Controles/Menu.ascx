<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="PI_VentanillaUnica.Controles.Menu" %>


<asp:Menu ID="mnPrincipal" runat="server" OnMenuItemClick="mnPrincipal_MenuItemClick" Orientation="Horizontal" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px" style="font-size: x-large; font-weight: 700; text-align: center;" Height="100%" RenderingMode="Table" Width="100%" >
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicItemTemplate>
        <%# Eval("Text") %>
    </DynamicItemTemplate>
    <Items>
        <asp:MenuItem Text="RADICACIÓN" ToolTip="Radicar Documentos" Value="1" NavigateUrl="~/Interfaces/frmRadicado.aspx" ImageUrl="~/Imagenes/blacklist_folder_edit.png">
        </asp:MenuItem>
        <asp:MenuItem Text="DESPACHO" ToolTip="Despacho de Documentos" Value="2" NavigateUrl="~/Interfaces/frmDespacho.aspx" ImageUrl="~/Imagenes/plane_check.png">
        </asp:MenuItem>
        <asp:MenuItem Text="TERCEROS" ToolTip="Terceros" Value="3" NavigateUrl="~/Interfaces/frmTercero.aspx" ImageUrl="~/Imagenes/conciliation.png">
        </asp:MenuItem>
        <asp:MenuItem Text="COLABORADORES" ToolTip="Funcionarios" Value="4" NavigateUrl="~/Interfaces/frmAdministracion.aspx" ImageUrl="~/Imagenes/activity.png">
        </asp:MenuItem>
        <asp:MenuItem Text="INFORMES" ToolTip="Informes" Value="5" NavigateUrl="~/Interfaces/frmInformes.aspx" ImageUrl="~/Imagenes/report.png">
        </asp:MenuItem>
        <asp:MenuItem Text="CERRAR SESIÓN" ToolTip="Cerrar Sesión" Value="-1" ImageUrl="~/Imagenes/close.png"></asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticSelectedStyle BackColor="#507CD1" />
</asp:Menu>
