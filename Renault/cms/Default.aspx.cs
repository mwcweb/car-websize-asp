using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Renault.cms
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection coonn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["admin"] == "gaest") Response.Redirect("../Default.aspx");
            if (!IsPostBack) drop();
        }

        protected void Button_log_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Default.aspx");
        }
        protected void drop()
        {
            SqlCommand cmd = new SqlCommand("select * from type", coonn);
            coonn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                ListItem valg = new ListItem();
                valg.Text = "Valg";
                valg.Value = "Valg";
                DropDownList_kat.Items.Add(valg);
                while (read.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = read["type"].ToString();
                    item.Value = read["Id"].ToString();
                    DropDownList_kat.Items.Add(item);
                }
            }
            catch { }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        protected void Button_slet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "slet";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = DropDownList_kat.SelectedValue;

            int row = 0;
            conn.Open();
            try
            {
                row = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            Label_slet.Text = row > 0 ? "fint" : "fejl";
        }

  
    }
}