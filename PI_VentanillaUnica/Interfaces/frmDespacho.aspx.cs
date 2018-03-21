using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class frmDespacho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Ventanilla.Logica.Clases.clsDespacho obclsDespacho = new Ventanilla.Logica.Clases.clsDespacho();
                pnlAdicionar.Visible = false;
                pnlModificar.Visible = false;

                if (string.IsNullOrEmpty(txtIdentifacion.Text))
                {
                    gvwDatos.DataSource = obclsDespacho.lsConsultarDespacho();
                    gvwDatos.DataBind();
                }
                else
                {
                    gvwDatos.DataSource = obclsDespacho.lsConsultarDespachoId(Convert.ToInt64(txtIdentifacion.Text));
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
                    txtDescripcionDespachoMod.Text = gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtDestinoDespachoMod.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtFechaDestinoMod.Text = gvwDatos.Rows[inIndice].Cells[3].Text;

                    pnlModificar.Visible = true;
                    pnlAdicionar.Visible = false;
                }
                else if (e.CommandName == "Eliminar")
                {
                    Ventanilla.Logica.Clases.clsDespacho obclsDespacho = new Ventanilla.Logica.Clases.clsDespacho();
                    string stMensajeConfirmacion = obclsDespacho.stEliminarDespacho(Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodId")).Text));

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
                Ventanilla.Logica.Clases.clsDespacho obclsDespacho = new Ventanilla.Logica.Clases.clsDespacho();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtCodigoDespachoAdd.Text)) stMensaje += "Código, \\n";
                if (string.IsNullOrEmpty(txtDescripcionDespachoAdd.Text)) stMensaje += "Descripción, \\n";
                if (string.IsNullOrEmpty(txtDestinoDespachoAdd.Text)) stMensaje += "Destino y\\n";
                if (string.IsNullOrEmpty(txtFechaDestinoAdd.Text)) stMensaje += "Fecha";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsDespacho.stInsertarDespacho(Convert.ToInt64(txtCodigoDespachoAdd.Text),
                    txtDescripcionDespachoAdd.Text,
                    txtDestinoDespachoAdd.Text,
                    txtFechaDestinoAdd.Text);

                Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                btnConsulta_Click(btnConsulta, new EventArgs());
                pnlAdicionar.Visible = true;
                txtCodigoDespachoAdd.Text = txtDescripcionDespachoAdd.Text = txtDestinoDespachoAdd.Text = txtFechaDestinoAdd.Text = "";
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡ Debe ingresar al menos los siguientes datos : \\n" + ex.Message + " !!!" + "');</Script>"); pnlAdicionar.Visible = true; }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = true;
        }

        protected void btnOkMod_Click(object sender, EventArgs e)
        {
            try
            {
                Ventanilla.Logica.Clases.clsDespacho obclsDespacho = new Ventanilla.Logica.Clases.clsDespacho();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtDescripcionDespachoMod.Text)) stMensaje += "Ingrese Descripción del Despacho \\n";
                if (string.IsNullOrEmpty(txtDestinoDespachoMod.Text)) stMensaje += "Ingrese Destino del Despacho \\n";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsDespacho.stModificarDespacho(Convert.ToInt64(lbCodMod.Text),
                    txtDescripcionDespachoMod.Text,
                    txtDestinoDespachoMod.Text,
                    txtFechaDestinoMod.Text);

                Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                btnConsulta_Click(btnConsulta, new EventArgs());
                pnlModificar.Visible = false;

            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>"); pnlModificar.Visible = true; }
        }

        protected void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = false;
            txtCodigoDespachoAdd.Text = txtDescripcionDespachoAdd.Text = txtDestinoDespachoAdd.Text = txtFechaDestinoAdd.Text = "";
        }

        protected void btnCancelarMod_Click(object sender, EventArgs e)
        {
            pnlModificar.Visible = false;
        }
    }
}