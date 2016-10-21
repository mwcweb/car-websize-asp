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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_log_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from users where brn = @brn and pass = @pass", conn);

            cmd.Parameters.Add("@brn", SqlDbType.VarChar, 20).Value = TextBox_brn.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 10).Value = TextBox_pass.Text;

            conn.Open();

            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                Session["admi"] = read["brn"].ToString();
                Response.Redirect("db.aspx");
            }
            else
            {
                Label_ok.Text = "dår";
            }
        }
    }
}