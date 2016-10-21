        using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class CMS : System.Web.UI.MasterPage
{
    private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["login"] == "gaest") Response.Redirect("Default.aspx");

        Label_brn.Text = Session["login"].ToString();
        
        vis();

        if (Session["funktion"] == null)
        {
            Session["funktion"] = hent(Convert.ToInt16(Session["brugeid"]));
        }

        DataTable dt2=new DataTable();
        dt2=(DataTable)Session["funktion"];
        foreach (DataRow row in dt2.Rows)
        {
            switch(row["funktion"].ToString())
            {
                case "butik":
                    LinkButton_order.Visible = true;
                    LinkButton_vare.Visible = true;
                    break;
                case "nyhed":
                    LinkButton_nyhed.Visible = true;
                    LinkButton_nyhede.Visible = true;
                    break;
                case "web":
                    LinkButton_kontakt.Visible = true;
                    LinkButton_adr.Visible = true;
                    LinkButton_team.Visible = true;
                    LinkButton_koret.Visible = true;
                    LinkButton_kalenden.Visible = true;
                    LinkButton_forside.Visible = true;
                    LinkButton_bane.Visible = true;
                    break;
            }
        }
    }
    protected void Button_log_ud_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session["login"] = "gaest";
        Response.Redirect("Default.aspx");
    }
    private DataTable hent(int brugeID)
    {
        SqlDataAdapter ada = new SqlDataAdapter(@"
                 SELECT dbo.bruger.*, dbo.rolle.funktion FROM dbo.bruger INNER JOIN dbo.rolle ON
                 dbo.bruger.fk_rolle = dbo.rolle.id where dbo.bruger.id=" + brugeID, conn);
        DataTable dt = new DataTable();
        ada.Fill(dt);
        return dt;
    }
    private void vis()
    {
        LinkButton_order.Visible = false;
        LinkButton_adr.Visible = false;
        LinkButton_kontakt.Visible = false;
        LinkButton_nyhed.Visible = false;
        LinkButton_bane.Visible = false;
        LinkButton_forside.Visible = false;
        LinkButton_kalenden.Visible = false;
        LinkButton_koret.Visible = false;
        LinkButton_nyhede.Visible = false;
        LinkButton_team.Visible = false;
        LinkButton_vare.Visible = false;
    }
}
