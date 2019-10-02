using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DDLSubject.Items.Add("COD");
            DDLSubject.Items.Add("OOP");
            DDLSubject.Items.Add("DS");
            DDLSubject.Items.Add("SCLD");
            DDLSubject.Items.Add("EM-III");
        }
    }

    protected void DDLSubject_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string name = txt_name.Text;
        string rollno = txt_rollno.Text.ToString();
        string subject = DDLSubject.SelectedItem.Text;
        if(name=="" || rollno==null)
        {
            return;
        }
     string url=String.Format("Default2.aspx? &name={0}&rollno={1}&subject={2}",Server.UrlEncode(name),Server.UrlEncode(rollno),Server.UrlEncode(subject));
        Response.Redirect(url);
    }
}