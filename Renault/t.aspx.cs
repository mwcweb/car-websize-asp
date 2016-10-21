using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Renault
{
    public partial class t : System.Web.UI.Page
    {
        SqlConnection coonn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        int sum = 0;
        int sum1 = 0;
        int kr = 0;
        int kr1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["admi"] == "gaest") Response.Redirect("Default.aspx");

            string bilID = "";
            int bi = 0;
            if (Request.QueryString["brn"] != null)
            {
                bilID = Request.QueryString["brn"].ToString();
                bi = Convert.ToInt32(Request.QueryString["id1"]);
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            SqlCommand cmd = new SqlCommand("select * from bn where brn='" + bilID + "'", coonn);
            coonn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string actor = read["rolle"].ToString();
       
            switch (read["rolle"].ToString())
            {
                case "s":
                    Calendar1.Visible = false;
                    break;
                case "a":
                    CheckBox1.Visible = false;
                    break;
            }    coonn.Close();

        }
    }
}