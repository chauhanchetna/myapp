using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            FillState();
        }
    }

    private void FillState()
    {
        ddlstate.Items.Add("Gujarat");
        ddlstate.Items.Add("Rajasthan");
        ddlstate.Items.Add("Maharastra");

        ListItem li = new ListItem();
        li.Value = "0";
        li.Text = "--Select State--";
        ddlstate.Items.Insert(0, li);
    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlcity.Items.Clear();

        ListItem li = new ListItem();
        li.Value = "0";
        li.Text = "--Select City--";
        ddlcity.Items.Insert(0, li);

        if (ddlstate.SelectedItem.Text == "Gujarat")
        {
            ddlcity.Items.Add("Vadodara");
            ddlcity.Items.Add("Ahmedabad");
            ddlcity.Items.Add("Surat");
        }

        else if (ddlstate.SelectedItem.Text == "Rajasthan")
        {
            ddlcity.Items.Add("Jaipur");
            ddlcity.Items.Add("Kota");
            ddlcity.Items.Add("Udaipur");
        }

        else if (ddlstate.SelectedItem.Text == "Maharastra")
        {
            ddlcity.Items.Add("Mumbai");
            ddlcity.Items.Add("Pune");
            ddlcity.Items.Add("Thane");
        }      
    }
}