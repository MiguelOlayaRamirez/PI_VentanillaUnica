using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class frmTercero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = true;
            gvwDatos.Visible = false;
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            gvwDatos.Visible = true;
            try 
            {
                Ventanilla.Logica.Clases.clsTerceros obclsTerceros = new Ventanilla.Logica.Clases.clsTerceros();
                pnlAdicionar.Visible = false;
                pnlModificar.Visible = false;

                if (string.IsNullOrEmpty(txtIdentifacion.Text))
                {
                    gvwDatos.DataSource = obclsTerceros.stConsultarTercero();
                    gvwDatos.DataBind();
                }
                else
                {
                    gvwDatos.DataSource = obclsTerceros.stConsultarTerceroId(Convert.ToInt64(txtIdentifacion.Text));
                    gvwDatos.DataBind();
                }
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>"); }

        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try 
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName == "Modificar")
                {
                    lbCodMod.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodId")).Text;
                    txtTelefonoTerceroMod.Text = gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtCorreoTerceroMod.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtDescripcionTerceroMod.Text = gvwDatos.Rows[inIndice].Cells[3].Text;

                    pnlModificar.Visible = true;
                    pnlAdicionar.Visible = false;
                }
                else if (e.CommandName == "Eliminar")
                {
                    Ventanilla.Logica.Clases.clsTerceros obclsTerceros = new Ventanilla.Logica.Clases.clsTerceros();
                    string stMensajeConfirmacion = obclsTerceros.stEliminarTercero(Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodId")).Text));

                    Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                    btnConsulta_Click(btnConsulta, new EventArgs());
                    pnlModificar.Visible = false;
                    pnlAdicionar.Visible = false;
                }
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>"); }
        }

        protected void btnOkAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                Ventanilla.Logica.Clases.clsTerceros obclsTerceros = new Ventanilla.Logica.Clases.clsTerceros();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtCodigoTerceroAdd.Text)) stMensaje += "Código, \\n";
                if (string.IsNullOrEmpty(txtTelefonoTerceroAdd.Text)) stMensaje += "Telefono, \\n";
                if (string.IsNullOrEmpty(txtCorreoTerceroAdd.Text)) stMensaje += "E-Mail y\\n";
                if (string.IsNullOrEmpty(txtDescripcionTerceroAdd.Text)) stMensaje += "Descripción";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsTerceros.stInsertarTercero(Convert.ToInt64(txtCodigoTerceroAdd.Text),
                    txtTelefonoTerceroAdd.Text,
                    txtCorreoTerceroAdd.Text,
                    txtDescripcionTerceroAdd.Text);

                Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                btnConsulta_Click(btnConsulta, new EventArgs());
                pnlAdicionar.Visible = true;
                txtCodigoTerceroAdd.Text = txtTelefonoTerceroAdd.Text = txtCorreoTerceroAdd.Text = txtDescripcionTerceroAdd.Text = "";
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡ Debe ingresar al menos los siguientes datos : \\n" + ex.Message + " !!!" + "');</Script>"); pnlAdicionar.Visible = true; }
        }

        protected void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = false;
            txtCodigoTerceroAdd.Text = txtTelefonoTerceroAdd.Text = txtCorreoTerceroAdd.Text = txtDescripcionTerceroAdd.Text = "";
        }

        protected void btnOkMod_Click(object sender, EventArgs e)
        {
            try 
            {
                Ventanilla.Logica.Clases.clsTerceros obclsTerceros = new Ventanilla.Logica.Clases.clsTerceros();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtTelefonoTerceroMod.Text)) stMensaje += "Ingrese Telefono Tercero, \\n";
                if (string.IsNullOrEmpty(txtCorreoTerceroMod.Text)) stMensaje += "Ingrese E-Mail Tercero \\n";
                if (string.IsNullOrEmpty(txtDescripcionTerceroMod.Text)) stMensaje += "Ingrese Descripción Tercero";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsTerceros.stModificarTercero(Convert.ToInt64(lbCodMod.Text),
                    txtTelefonoTerceroAdd.Text,
                    txtCorreoTerceroAdd.Text,
                    txtDescripcionTerceroAdd.Text);

                Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                btnConsulta_Click(btnConsulta, new EventArgs());
                pnlModificar.Visible = false;
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>"); pnlModificar.Visible = true; }
        }

        protected void btnCancelarMod_Click(object sender, EventArgs e)
        {
            pnlModificar.Visible = false;
        }
    }   
}