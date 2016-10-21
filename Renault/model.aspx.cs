using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Renault
{
    public partial class model : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from model", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_bil.DataSource = dt;
            Repeater_bil.DataBind();
        }
    }
}