using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Controles
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mnPrincipal_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (mnPrincipal.SelectedValue == "1") return;
            if (mnPrincipal.SelectedValue == "2") return;
            if (mnPrincipal.SelectedValue == "3") return;
            if (mnPrincipal.SelectedValue == "4") return;
            if (mnPrincipal.SelectedValue == "5") return;

                Response.Redirect("Login.aspx");
        }
    }
}