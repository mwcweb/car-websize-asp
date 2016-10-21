using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Renault
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from slider", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_bil.DataSource = dt;
            Repeater_bil.DataBind();
        }
    }
}