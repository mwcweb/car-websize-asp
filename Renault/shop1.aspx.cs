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
    public partial class shop1 : System.Web.UI.Page
    {
        SqlConnection coonn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        int sum = 0;
        int sum1 = 0;
        int kr = 0;
        int kr1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int bilID = 0;
            int bi = 0;
            if (Request.QueryString["id"] != null && Request.QueryString["id1"] != null)
            {
                bilID = Convert.ToInt32(Request.QueryString["id"]);
                bi = Convert.ToInt32(Request.QueryString["id1"]);
            }
            else
            {
                Response.Redirect("shop.aspx");
            }
           ;

            SqlCommand cmd1 = new SqlCommand("select * from shop where Id=" + bilID, coonn);

            coonn.Open();

            SqlDataReader read1 = cmd1.ExecuteReader();
            read1.Read();
            sum1 = Convert.ToInt32(read1["kr"]);
            TextBox_v.Text = read1["vare"].ToString();
            coonn.Close();
            
            if (bi != 0)
            {
                SqlCommand cmd = new SqlCommand("select * from shop where Id=" + bi, coonn);

                coonn.Open();

                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                sum = Convert.ToInt32(read["kr"]);
                TextBox_va.Text = read["vare"].ToString();
                coonn.Close();
            }
           
            kr = sum + sum1;
            TextBox_sum.Text = kr.ToString();
        }


        protected void Button_plus_Click(object sender, EventArgs e)
        {

            int a = 1;
            a = int.Parse(TextBox_antal.Text);
            int cc = 1;
            int s = a + cc++;
            TextBox_antal.Text = s.ToString();
        }
        protected void Button__Click(object sender, EventArgs e)
        {
            int a = 1;
            a = int.Parse(TextBox_a.Text);
            int cc = 1;
            int s = a + cc++;
            TextBox_a.Text = s.ToString();
        }

        protected void Button_shop_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("update shop set antal = (antal-@a) where vare=" + TextBox_va.Text, conn);

            //cmd.Parameters.Add("@a", SqlDbType.Int).Value = TextBox_antal.Text;

            //int rowi = 0;

            //conn.Open();
            //try
            //{
            //    rowi = cmd.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
            //    if (conn != null)
            //        conn.Close();
            //}
            //SqlCommand cmd1 = new SqlCommand("update shop set antal = (antal-@an) where vare=" + TextBox_v.Text, conn);

            //cmd1.Parameters.Add("@an", SqlDbType.Int).Value = TextBox_a.Text;
            //int rowi1 = 0;

            //conn.Open();
            //try
            //{
            //    rowi1 = cmd1.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
            //    if (conn != null)
            //        conn.Close();
            //}
            //if (rowi > 0)
            //{
                Response.Redirect("shop2.aspx?vare=" + TextBox_v.Text + "&&vare1=" + TextBox_va.Text + "&&sum=" + TextBox_sum.Text + "&&an=" + TextBox_antal.Text + "&&an1=" + TextBox_a.Text);
            //}
        }

        protected void mus_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt16(TextBox_antal.Text);
            var1 = var1 - 1;

            TextBox_antal.Text = var1.ToString();
        }

        protected void Button_mums_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt16(TextBox_a.Text);
            var1 = var1 - 1;

            TextBox_a.Text = var1.ToString();
        }

        protected void Button_op_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(TextBox_antal.Text);
            int t = Convert.ToInt16(TextBox_a.Text);
            int an = s * sum1 + t * sum;
            TextBox_sum.Text = an.ToString();
        }
    }
}