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
    public partial class bil : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            int bilID = 0;
            if(Request.QueryString["id"] != null)
            {
                bilID = Convert.ToInt32(Request.QueryString["id"]);
            }
            else
            {
                Response.Redirect("model.aspx");
            }
            SqlDataAdapter ada = new SqlDataAdapter("select * from model where id=" + bilID, conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_model.DataSource = dt;
            Repeater_model.DataBind();


        }
    }
}