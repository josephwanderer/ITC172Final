using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Give : System.Web.UI.Page
{
    AssistServiceReference.AssistServiceServiceClient sc = new AssistServiceReference.AssistServiceServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
            Response.Redirect("Default.aspx");
    }

    protected void DonateButton_Click(object sender, EventArgs e)
    {
        int key = (int)Session["userKey"];
        decimal amount = decimal.Parse(DonateTextBox.Text);

        sc.SubmitDonation(key, amount);
        Response.Redirect("Default.aspx");


    }
}