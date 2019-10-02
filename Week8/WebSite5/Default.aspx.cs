using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   private string[] car_model = { "Corolla", "S-Class", "Nano" };
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DDLManufacturer.Items.Add("Toyota");
            DDLManufacturer.Items.Add("Mercedes-Benz");
            DDLManufacturer.Items.Add("Tata Motors");
        }
    }

    protected void DDLManufacturer_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string modelname = DDLManufacturer.SelectedItem.Text;
        string carname = txt_model_name.Text;
        if (carname == "")
        {
            return;
        }
        string _rurl = String.Format("Details.aspx? &modelname={0}&carname={1}", Server.UrlEncode(modelname), Server.UrlEncode(carname));
        Response.Redirect(_rurl);
    }
}