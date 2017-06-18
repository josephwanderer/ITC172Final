using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationHistory : System.Web.UI.Page
{
    AssistServiceReference.AssistServiceServiceClient sc = new AssistServiceReference.AssistServiceServiceClient();
    AssistServiceReference.DonationInfo[] donInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        AssistServiceReference.DonationInfo[] donInfo;
        donInfo = sc.GetDonations(int.Parse(Session["userKey"].ToString()));
        GridView1.DataSource = donInfo;
        GridView1.DataBind();


    }
}