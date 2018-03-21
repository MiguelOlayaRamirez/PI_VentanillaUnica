using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class frmAdministracion : System.Web.UI.Page
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
                Ventanilla.Logica.Clases.clsAdministracion obclsAdministracion = new Ventanilla.Logica.Clases.clsAdministracion();
                pnlAdicionar.Visible = false;
                pnlModificar.Visible = false;

                if (string.IsNullOrEmpty(txtIdentifacion.Text))
                {
                    gvwDatos.DataSource = obclsAdministracion.lsConsultarColaborador();
                    gvwDatos.DataBind();
                }
                else 
                {
                    gvwDatos.DataSource = obclsAdministracion.lsConsultarColaboradorId(Convert.ToInt64(txtIdentifacion.Text));
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
                    txtNombreAdmonMod.Text = gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtApellidoAdmonMod.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtCargoAdmonMod.Text = gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtAreaAdmonMod.Text = gvwDatos.Rows[inIndice].Cells[4].Text;
                    txtCodDespachoAdmonbMod.Text = gvwDatos.Rows[inIndice].Cells[5].Text;
                    txtCodProcesoAdmonMod.Text = gvwDatos.Rows[inIndice].Cells[6].Text;

                    pnlModificar.Visible = true;
                    pnlAdicionar.Visible = false;
                }
                else if (e.CommandName == "Eliminar")
                {
                    Ventanilla.Logica.Clases.clsAdministracion obclsAdministracion = new Ventanilla.Logica.Clases.clsAdministracion();
                    string stMensajeConfirmacion = obclsAdministracion.stEliminarColaborador(Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodId")).Text));
                    
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
                Ventanilla.Logica.Clases.clsAdministracion obclsAdministracion = new Ventanilla.Logica.Clases.clsAdministracion();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtCodigoAdmonAdd.Text)) stMensaje += "Código Colaborador, \\n";
                if (string.IsNullOrEmpty(txtNombreAdmonAdd.Text)) stMensaje += "Nombre Colaborador, \\n";
                if (string.IsNullOrEmpty(txtApellidoAdmonAdd.Text)) stMensaje += "Apellido Colaborador, \\n";
                if (string.IsNullOrEmpty(txtCargoAdmonAdd.Text)) stMensaje += "Cargo Colaborador y\\n";
                if (string.IsNullOrEmpty(txtAreaAdmonAdd.Text)) stMensaje += "Área del Colaborador";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsAdministracion.stInsertarColaborador(Convert.ToInt64(txtCodigoAdmonAdd.Text),
                    txtNombreAdmonAdd.Text,
                    txtApellidoAdmonAdd.Text,
                    txtCargoAdmonAdd.Text,
                    txtAreaAdmonAdd.Text,
                    Convert.ToInt64(txtCodDespachoAdmonAdd.Text),
                    Convert.ToInt64(txtCodProcesoAdmonAdd.Text));

                Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                btnConsulta_Click(btnConsulta, new EventArgs());
                pnlAdicionar.Visible = false;
                txtCodigoAdmonAdd.Text = txtNombreAdmonAdd.Text = txtApellidoAdmonAdd.Text = txtCargoAdmonAdd.Text = txtAreaAdmonAdd.Text = txtCodProcesoAdmonAdd.Text = txtCodDespachoAdmonAdd.Text = "";
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡ Debe ingresar al menos los siguientes datos : \\n" + ex.Message + " !!!" + "');</Script>"); pnlAdicionar.Visible = true; }
        }

        protected void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = false;
            txtCodigoAdmonAdd.Text = txtNombreAdmonAdd.Text = txtApellidoAdmonAdd.Text = txtCargoAdmonAdd.Text = txtAreaAdmonAdd.Text = txtCodProcesoAdmonAdd.Text = txtCodDespachoAdmonAdd.Text = "";
        }

        protected void btnOkMod_Click(object sender, EventArgs e)
        {
            try 
            {
                Ventanilla.Logica.Clases.clsAdministracion obclsAdministracion = new Ventanilla.Logica.Clases.clsAdministracion();
                string stMensaje = "";
                string stMensajeConfirmacion = "";

                if (string.IsNullOrEmpty(txtNombreAdmonAdd.Text)) stMensaje += "Ingrese Nombre Colaborador, \\n";
                if (string.IsNullOrEmpty(txtApellidoAdmonAdd.Text)) stMensaje += "Ingrese Apellido Colaborador, \\n";

                if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                stMensajeConfirmacion = obclsAdministracion.stModificarColaborador(Convert.ToInt64(lbCodMod.Text),
                    txtNombreAdmonAdd.Text,
                    txtApellidoAdmonAdd.Text,
                    txtCargoAdmonAdd.Text,
                    txtAreaAdmonAdd.Text,
                    Convert.ToInt64(txtCodDespachoAdmonAdd.Text),
                    Convert.ToInt64(txtCodProcesoAdmonAdd.Text));

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

       
