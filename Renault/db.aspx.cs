using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Renault
{
    public partial class db : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["admi"] == "gaest") Response.Redirect("Default.aspx");
        }

        protected void Button_log_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}