using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class CargaDocumento : System.Web.UI.Page
    {
        string carpeta;
        protected void Page_Load(object sender, EventArgs e)
        {
            carpeta = Path.Combine(Request.PhysicalApplicationPath, "CargaDocumento");
            txtRuta.Text = carpeta;
        }

        protected void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile.FileName == " ")
            {
                txtNombreArchivo.Text = "No seleccionaste un Archivo valido";
            }
            else
            {
                string extencion = Path.GetExtension(FileUpload1.PostedFile.FileName);
                switch (extencion.ToLower())
                {
                    case ".jpg":
                    case ".gif":
                    case ".png":
                    case ".pdf":
                        break;

                    default:
                        txtNombreArchivo.Text = "Extencion No vaida";

                        return;
                }

                try
                {
                    string archivo = Path.GetExtension(FileUpload1.PostedFile.FileName);
                    string carpeta_final = Path.Combine(carpeta, archivo);
                    FileUpload1.PostedFile.SaveAs(carpeta_final);
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>  swal('Archivo cargado', '')) </script>");
                    txtNombreArchivo.Text = "Archivo cargado";
                   


                }
                catch (Exception ex) { throw ex; }

            }
        }
    }
    }
