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
    public partial class booking : System.Web.UI.Page
    {
        SqlConnection coonn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) drop();
            Panel_til.Visible = false;
            Panel_fra.Visible = false;
        }

        protected void Button_book_Click(object sender, EventArgs e)
        {
            string sql = "select COUNT(Id) AS cid from udleje";
            bool where = false;
            if(DropDownList_model.SelectedValue != "")
            {
                sql += " where model ='" + DropDownList_model.SelectedValue + "'";
            }
            if(TextBox_til.Text !="" && TextBox_fra.Text != "")
            {
                sql += " AND fra BETWEEN '" + TextBox_fra.Text + "' AND '" + TextBox_til.Text + "' OR til BETWEEN '" + TextBox_fra.Text + "' AND '" + TextBox_til.Text + "'";
            }
            SqlCommand cmd = new SqlCommand(sql, coonn);
            coonn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            int row = Convert.ToInt32(read["cid"]);
            coonn.Close();
            if(row == 1)
            {
                Label_book.Text = "dår";
            }
            else if(row == 3)
            {
                Label_book.Text = "ikke";
            }
            else
            {
                SqlCommand ind = new SqlCommand("insert into udleje(model, fra, til) values(@model, @fra, @til)", conn);

                ind.Parameters.Add("@model", SqlDbType.VarChar, 20).Value = DropDownList_model.SelectedValue;
                ind.Parameters.Add("@fra", SqlDbType.VarChar, 20).Value = TextBox_fra.Text;
                ind.Parameters.Add("@til", SqlDbType.VarChar, 20).Value = TextBox_til.Text;

                int rowi = 0;

                conn.Open();
                try
                {
                    rowi = ind.ExecuteNonQuery();
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
                    Response.Redirect("book.aspx?model?" + DropDownList_model.SelectedValue + "&fra=" + TextBox_fra.Text + "&til=" + TextBox_til.Text);
                }
            }
            
        }
        private void drop()
        {
            SqlCommand cmd = new SqlCommand("select * from model", coonn);
            coonn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                ListItem valg = new ListItem();
                valg.Text = "Valg";
                valg.Value = "Valg";
                DropDownList_model.Items.Add(valg);
                while (read.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = read["model"].ToString();
                    item.Value = read["model"].ToString();
                    DropDownList_model.Items.Add(item);
                }
            }
            catch { }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        protected void Calendar_fra_SelectionChanged(object sender, EventArgs e)
        {
            TextBox_fra.Text = Calendar_fra.SelectedDate.ToShortDateString();
            Panel_fra.Visible = false;
        }

        protected void Calendar_til_SelectionChanged(object sender, EventArgs e)
        {
            TextBox_til.Text = Calendar_til.SelectedDate.ToShortDateString();
            Panel_til.Visible = false;
        }

        protected void Button_fra_Click(object sender, EventArgs e)
        {
            Panel_fra.Visible = true;
        }

        protected void Button_til_Click(object sender, EventArgs e)
        {
            Panel_til.Visible = true;
        }
    }
}