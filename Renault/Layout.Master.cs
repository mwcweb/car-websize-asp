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
    public partial class Layout : System.Web.UI.MasterPage
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter me = new SqlDataAdapter("select * from menu", conn);
            SqlDataAdapter ty = new SqlDataAdapter("select * from typerb", conn);

            DataTable nu = new DataTable();
            DataTable pe = new DataTable();

            me.Fill(nu);
            ty.Fill(pe);

            Repeater_menu.DataSource = nu;
            Repeater_menu.DataBind();

            Repeater_type.DataSource = pe;
            Repeater_type.DataBind();
        }

        protected void Button_sog_Click(object sender, EventArgs e)
        {
            string sog = TextBox_sog.Text;
            Response.Redirect("sog.aspx?sog=" + sog);
        }
    }
}