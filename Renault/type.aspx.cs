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
    public partial class Type : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            int bil = 0;
            if (Request.QueryString["id"] != null)
            {
                bil = Convert.ToInt32(Request.QueryString["id"].ToString());
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            SqlDataAdapter ada = new SqlDataAdapter("select * from model inner join typerb on model.fk_type = typerb.id where typerb.Id =" + bil + "", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_bil.DataSource = dt;
            Repeater_bil.DataBind();

            SqlCommand cmd = new SqlCommand("select * from typerb where id=" + bil, conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            Label_type.Text = read["type"].ToString();
            conn.Close();
        }
    }
}