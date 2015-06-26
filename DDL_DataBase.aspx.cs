using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Server=c7300916-6799-4d9c-a5b7-a4c300aa6af9.sqlserver.sequelizer.com;Database=dbc730091667994d9ca5b7a4c300aa6af9;User ID=wcwbsikgyhwjiitv;Password=QHW5AocfXkTBgWdGLxNpYLp3cS5NUdT3ghabLA8PdWnGG7ijntT5NEaes32RrwsU;");


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            FillState();           
        }
    }

    private void FillState()
    {
        SqlCommand cmd = new SqlCommand("select * from TblState", conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        ddlstate.DataSource = dr;
        ddlstate.DataTextField = "sname";
        ddlstate.DataValueField = "sid";
        ddlstate.DataBind();
        
        ListItem li = new ListItem();
        li.Value = "0";
        li.Text = "---Select State---";
        ddlstate.Items.Insert(0, li);
        conn.Close();
    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt16(ddlstate.SelectedValue);
        SqlCommand cmd = new SqlCommand("select * from TblCity where stateid='"+id+"'", conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        ddlcity.DataSource = dr;
        ddlcity.DataTextField = "cname";
        ddlcity.DataValueField = "cid";
        ddlcity.DataBind();

        ListItem li = new ListItem();
        li.Value = "0";
        li.Text = "---Select City---";
        ddlcity.Items.Insert(0, li);
        conn.Close();
    }
}