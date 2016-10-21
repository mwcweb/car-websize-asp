using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Mail;
using System.Net.Mail;

namespace Renault
{
    public partial class kontakt : System.Web.UI.Page
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from adr", co);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_adr.DataSource = dt;
            Repeater_adr.DataBind();
        }
        protected void mail()
        {
            System.Net.Mail.MailMessage nymail = new System.Net.Mail.MailMessage();
            nymail.Body = "svwwsug";
            nymail.To.Add(TextBox_epost.Text);
            nymail.From = new MailAddress( "RE@LEGASP.DK");
            nymail.Subject = "RE";
            SmtpClient sm = new SmtpClient("web.legasp.dk");
            sm.Send(nymail);

        }

        protected void Button_send_Click(object sender, EventArgs e)
        {
            //mail();
            SqlCommand cmd = new SqlCommand("insert into kontakt(navn, epost, emme, besked, dato) values (@navn, @epost, @emme, @besked, @dato)", con);

            cmd.Parameters.Add("@navn", SqlDbType.VarChar, 40).Value = TextBox_navn.Text;
            cmd.Parameters.Add("@epost", SqlDbType.VarChar, 60).Value = TextBox_epost.Text;
            cmd.Parameters.Add("@emme", SqlDbType.VarChar, 30).Value = TextBox_emme.Text;
            cmd.Parameters.Add("@besked", SqlDbType.Text).Value = TextBox_besked.Text;
            cmd.Parameters.Add("@dato", SqlDbType.DateTime).Value = DateTime.Now.ToString();

            int row = 0;
            con.Open();
            try
            {
                row = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                if (con != null)
                    con.Close();
            }
            Label_send.Text = row > 0 ? "fint" : "fejl";
        }
    }
}