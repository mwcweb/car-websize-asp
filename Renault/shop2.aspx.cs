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
    public partial class shop2 : System.Web.UI.Page
    {
        SqlConnection coonn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        int sum = 0;
        int sum1 = 0;
        int kr = 0;
        int kr1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string bilID = "";
            string bi = "";
            if (Request.QueryString["vare"] != null && Request.QueryString["vare1"] != null)
            {
                bilID = Request.QueryString["vare"];
                bi = Request.QueryString["vare1"];
            }
            else
            {
                Response.Redirect("shop.aspx");
            }
            TextBox_sum.Text = Request.QueryString["sum"].ToString();
            TextBox_v.Text = Request.QueryString["vare1"].ToString();
            TextBox_va.Text = Request.QueryString["vare"].ToString();
            TextBox_a.Text = Request.QueryString["an"].ToString();
            TextBox_antal.Text = Request.QueryString["an1"].ToString();
        }

        protected void Button_shop_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into kob (navn, epost, sum, vare, vare1, an, an1, dato) values (@navn, @epost, @sum, @vare, @vare1, @an, @an1, @dato)", conn);

            cmd.Parameters.Add("@navn", SqlDbType.VarChar, 40).Value = TextBox_navn.Text;
            cmd.Parameters.Add("@epost", SqlDbType.VarChar, 60).Value = TextBox_epost.Text;
            cmd.Parameters.Add("@sum", SqlDbType.Int).Value = TextBox_sum.Text;
            cmd.Parameters.Add("@vare", SqlDbType.VarChar, 40).Value = TextBox_va.Text;
            cmd.Parameters.Add("@vare1", SqlDbType.VarChar, 40).Value = TextBox_v.Text;
            cmd.Parameters.Add("@an", SqlDbType.Int).Value = TextBox_antal.Text;
            cmd.Parameters.Add("@an1", SqlDbType.Int).Value = TextBox_a.Text;
            cmd.Parameters.Add("@dato", SqlDbType.DateTime).Value = DateTime.Now.ToLongDateString();
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
            SqlCommand cmd2 = new SqlCommand("update shop set antal = (antal-@a) where vare=" + TextBox_va.Text, conn);

            cmd2.Parameters.Add("@a", SqlDbType.Int).Value = TextBox_antal.Text;

            int rowi = 0;

            conn.Open();
            try
            {
                rowi = cmd2.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            SqlCommand cmd1 = new SqlCommand("update shop set antal = (antal-@an) where vare=" + TextBox_v.Text, conn);

            cmd1.Parameters.Add("@an", SqlDbType.Int).Value = TextBox_a.Text;
            int rowi1 = 0;

            conn.Open();
            try
            {
                rowi1 = cmd1.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            if (row > 0)
            {
                Response.Redirect("shop3.aspx");
            }


        }
    }
}