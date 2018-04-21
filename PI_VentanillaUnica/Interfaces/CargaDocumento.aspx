<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/Principal.Master" AutoEventWireup="true" CodeBehind="CargaDocumento.aspx.cs" Inherits="PI_VentanillaUnica.Interfaces.CargaDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">

 
     <link href="../CSS/sweetalert.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js" type="text/javascript"></script>

     <div class="container">
        <div class="mx-auto mt-12">
            <%-- FILA --%>
            <div class="form-group">
                <div class="form-row" "align-content-center">CARGA DE DOCUMENTOS   <br /><br />
                    
                    <br />
                </div>
             </div>
             <div class="form-group">
                <div class="form-row">
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
                </div>
            </div>
             <div class="col-md-6">
                  Ruta Fisica del Server
                <asp:TextBox ID="txtRuta" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>

                  Nombre del Archivo
                <asp:TextBox ID="txtNombreArchivo" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>

             </div>
            </div>
          <div class="form-group">
                <div class="form-row">
                    <br />
                    <%-- COLUMNA 1 --%>
                    <div class="col-md-6">
                     
                        <asp:Button ID="btnGuardarArchivo" runat="server" OnClick="btnGuardarArchivo_Click" Text="Guardar" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
         </div>


</asp:Content>
