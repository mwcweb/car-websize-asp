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
    public partial class ava : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_sog_Click(object sender, EventArgs e)
        {
            string sql = "select * from model ";
            bool where = false;
            if (TextBox_model.Text.Length > 0)
            {
                sql += "where model like'%" + TextBox_model.Text + "%' ";
            }
            
            if(CheckBox_el.Checked && !CheckBox_diesel.Checked && !CheckBox_benzin.Checked)
            {
                sql += " and stof ='el'";
            }
            else if(CheckBox_el.Checked && CheckBox_benzin.Checked)
            {
                sql += " and stof ='el' and or ='benzin'";
            }
            else if(CheckBox_benzin.Checked && CheckBox_diesel.Checked && CheckBox_el.Checked)
            {
                sql += " and stof ='el' or stof ='benzin' or stof ='diesel'";
            }
            else if(CheckBox_el.Checked && CheckBox_diesel.Checked)
            {
                sql += " and stof ='el' or stof ='diesel'";
            }
            else if(CheckBox_benzin.Checked && CheckBox_diesel.Checked)
            {
                sql += " and stof ='diesel' or stof ='benzin'";
            }
            if (CheckBox_diesel.Checked  && !CheckBox_benzin.Checked && !CheckBox_el.Checked)
            {
                sql += " and stof ='diesel'";
            }
            if (CheckBox_benzin.Checked && !CheckBox_diesel.Checked && !CheckBox_el.Checked)
            {
                sql += " and stof ='benzin'";
            }
            if (TextBox_fra.Text.Length > 0 && TextBox_til.Text.Length > 0)
            {
                if (where)
                {
                    where = true;
                    sql += "where pris between'" + TextBox_fra.Text + "' and '" + TextBox_til.Text + "'";
                }
                else
                {
                    where = false;
                    sql += " and pris between'" + TextBox_fra.Text + "' and '" + TextBox_til.Text + "'";
                }
            }
            SqlDataAdapter ada = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_model.DataSource = dt;
            Repeater_model.DataBind();
        }
    }
}