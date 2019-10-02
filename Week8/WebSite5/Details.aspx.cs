/*Thanks to 3sne github { Mukur Panchani }*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        string gotModelNameAs = Request.QueryString["modelname"];
        string gotCarNameAs = Request.QueryString["carname"];
        lbl_view_area.Text += "Model Name " + gotModelNameAs + "\t" + "CarName " + gotCarNameAs;
    }

    protected void btn_goback_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}