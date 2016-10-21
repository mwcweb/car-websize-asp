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
    public partial class book : System.Web.UI.Page
    {
        SqlConnection coonn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drop();
                drop1();
            }

        }

        protected void Button_shop_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update shop set antal = (antal-1) where id=" + DropDownList_vare.SelectedValue, conn);

            int rowi = 0;

            conn.Open();
            try
            {
                rowi = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            SqlCommand cmd1 = new SqlCommand("update shop set antal = (antal-1) where id=" + DropDownList_vare1.SelectedValue, conn);

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
            if (rowi > 0)
            {
                Response.Redirect("shop1.aspx?id=" + DropDownList_vare.SelectedValue + "&&id1="  + DropDownList_vare1.SelectedValue);
            }


        }

        private void drop()
        {
            SqlCommand cmd = new SqlCommand("select * from shop", coonn);
            coonn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                ListItem valg = new ListItem();
                valg.Text = "Valg";
                valg.Value = "Valg";
                DropDownList_vare.Items.Add(valg);
                while (read.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = read["vare"].ToString() + "" + read["kr"].ToString();
                    item.Value = read["id"].ToString();
                    DropDownList_vare.Items.Add(item);
                }
            }
            catch { }
            finally
            {
                if (coonn != null)
                    coonn.Close();
            }
           
        }
        private void drop1()
        {
            SqlCommand cmd = new SqlCommand("select * from shop", coonn);
            coonn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                ListItem valg = new ListItem();
                valg.Text = "Valg";
                valg.Value = "0";
                DropDownList_vare1.Items.Add(valg);
                while (read.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = read["vare"].ToString() + "" + read["kr"].ToString();
                    item.Value = read["id"].ToString();
                    DropDownList_vare1.Items.Add(item);
                }
            }
            catch { }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }


        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

       
        }
    }
}