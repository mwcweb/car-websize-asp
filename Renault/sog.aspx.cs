using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Renault
{
    public partial class sog : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            string bil = "";
            if(Request.QueryString["sog"] != null)
            {
                bil = Request.QueryString["sog"].ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            SqlDataAdapter ada = new SqlDataAdapter("select * from model where model like'%" + bil.ToString() + "%'", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_bil.DataSource = dt;
            Repeater_bil.DataBind();
        }
    }
}