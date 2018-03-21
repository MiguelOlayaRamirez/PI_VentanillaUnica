using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class frmRadicado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void btnOkAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                Ventanilla.Logica.Clases.clsRadicado obclsRadicado = new Ventanilla.Logica.Clases.clsRadicado();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtCodigoRadicadoAdd.Text)) stMensaje += "Código, \\n";
                if (string.IsNullOrEmpty(txtCódigoTerceroAdd.Text)) stMensaje += "Código Tercero, \\n";
                if (string.IsNullOrEmpty(txtDescripcionRadicadoAdd.Text)) stMensaje += "Descricpión y\\n";
                if (string.IsNullOrEmpty(txtFechaRadicadoAdd.Text)) stMensaje += "Fecha Radicado";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsRadicado.stInsertarRadicado(Convert.ToInt64(txtCodigoRadicadoAdd.Text),
                    Convert.ToInt64(txtCódigoTerceroAdd.Text),
                    Convert.ToInt64(txtCódigoFuncionarioAdd.Text),
                    txtFechaRadicadoAdd.Text,
                    txtDescripcionRadicadoAdd.Text,
                    Convert.ToInt64(txtCodigoUsuarioAdd.Text));

                Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                btnConsulta_Click(btnConsulta, new EventArgs());
                pnlAdicionar.Visible = true;
                txtIdentifacion.Text = txtFechaRadicadoMod.Text = txtFechaRadicadoAdd.Text = txtDescripcionRadicadoMod.Text = txtDescripcionRadicadoAdd.Text = txtCodigoUsuarioMod.Text = txtCodigoUsuarioAdd.Text = txtCódigoTerceroMod.Text = txtCódigoTerceroAdd.Text = txtCodigoRadicadoAdd.Text = txtCódigoFuncionarioMod.Text = txtCódigoFuncionarioAdd.Text = ""; 
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡ Debe ingresar al menos los siguientes datos : \\n" + ex.Message + " !!!" + "');</Script>"); pnlAdicionar.Visible = true; }
        }

        protected void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = false;
            txtIdentifacion.Text = txtFechaRadicadoMod.Text = txtFechaRadicadoAdd.Text = txtDescripcionRadicadoMod.Text = txtDescripcionRadicadoAdd.Text = txtCodigoUsuarioMod.Text = txtCodigoUsuarioAdd.Text = txtCódigoTerceroMod.Text = txtCódigoTerceroAdd.Text = txtCodigoRadicadoAdd.Text = txtCódigoFuncionarioMod.Text = txtCódigoFuncionarioAdd.Text = "";
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Ventanilla.Logica.Clases.clsRadicado obclsRadicado = new Ventanilla.Logica.Clases.clsRadicado();
                pnlAdicionar.Visible = false;
                pnlModificar.Visible = false;

                if (string.IsNullOrEmpty(txtIdentifacion.Text))
                {
                    gvwDatos.DataSource = obclsRadicado.ConsultarRadicados();
                    gvwDatos.DataBind();
                }
                else
                {
                    gvwDatos.DataSource = obclsRadicado.ConsultarRadicadosId(Convert.ToInt64(txtIdentifacion.Text));
                    gvwDatos.DataBind();
                }
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>"); }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = true;
        }

        protected void btnOkMod_Click(object sender, EventArgs e)
        {
            try 
            {
                Ventanilla.Logica.Clases.clsRadicado obclsRadicado = new Ventanilla.Logica.Clases.clsRadicado();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtDescripcionRadicadoMod.Text)) stMensaje += "Ingrese Descripción para Radicar \\n";
                if (string.IsNullOrEmpty(txtFechaRadicadoMod.Text)) stMensaje += "Ingrese Fecha para Radicar \\n";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsRadicado.stModificarRadicado(Convert.ToInt64(lbCodMod.Text),
                    Convert.ToInt64(txtCódigoTerceroMod.Text),
                    Convert.ToInt64(txtCódigoFuncionarioMod.Text),
                    txtFechaRadicadoMod.Text,
                    txtDescripcionRadicadoMod.Text,
                    Convert.ToInt64(txtCodigoUsuarioMod.Text));

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

        protected void gvwDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName == "Modificar")
                {
                    lbCodMod.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodId")).Text;
                    txtCódigoTerceroMod.Text = gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtCódigoFuncionarioMod.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtFechaRadicadoMod.Text = gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtDescripcionRadicadoMod.Text = gvwDatos.Rows[inIndice].Cells[4].Text;
                    txtCodigoUsuarioMod.Text = gvwDatos.Rows[inIndice].Cells[5].Text;

                    pnlModificar.Visible = true;
                    pnlAdicionar.Visible = false;
                }
                else if (e.CommandName == "Eliminar")
                {
                    Ventanilla.Logica.Clases.clsRadicado obclsRadicado = new Ventanilla.Logica.Clases.clsRadicado();
                    string stMensajeConfirmacion = obclsRadicado.stEliminarRadicado(Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodId")).Text));

                    Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                    btnConsulta_Click(btnConsulta, new EventArgs());
                    pnlModificar.Visible = false;
                    pnlAdicionar.Visible = false;
                }
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>"); }
        }

        protected void txtIdentifacion_TextChanged(object sender, EventArgs e)
        {


        }
    }
}