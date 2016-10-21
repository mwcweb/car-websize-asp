using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Renault
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string brn = "mwc";
            string pass = "61";
            if (brn == TextBox_brn.Text && pass == TextBox_pass.Text)
            {
                Session["admi"] = brn;
                Response.Redirect("t.aspx?brn=" + brn);
            }
            else
            {
                Label_ok.Text = "prøv iggen";
            }
        }
    }
}