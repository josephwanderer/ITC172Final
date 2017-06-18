using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Events : System.Web.UI.Page
{
    string[,] events = new string[7, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
        events[0, 0] = "4/13/2017";
        events[0, 1] = "Thomas Jefferson's Birthday";
        events[1, 0] = "4/15/2017";
        events[1, 1] = "Happy Tax Day";
        events[2, 0] = "4/16/2017";
        events[2, 1] = "Easter Sunday";
        events[3, 0] = "5/14/2017";
        events[3, 1] = "Mother's Day";
        events[4, 0] = "5/14/2017";
        events[4, 1] = "Get Flowers for Mom";
        events[5, 0] = "5/29/2017";
        events[5, 1] = "Memorial Day";
        events[6, 0] = "6/18/2017";
        events[6, 1] = "Fathers Day";

    }

    protected void EventCalendar_SelectionChanged(object sender, EventArgs e)
    {
        ResultLabel.Text = "";
        string myDate = EventCalendar.SelectedDate.ToShortDateString();
        for (int i = 0; i < 7; i++)
        {
            if (events[i, 0].Equals(myDate))
            {
                ResultLabel.Text += events[i, 1] + "<br />";
            }
        }
    }

}