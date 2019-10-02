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
        if(IsPostBack)
        {
            return;
        }
        string getName = Request.QueryString["name"];
        string getRollNo = Request.QueryString["rollno"];
        string getSubject = Request.QueryString["subject"];
        lbl_name.Text += "Name "+getName+"\t"+"Rollno "+getRollNo;
        lbl_subject.Text += getSubject;
    }

    protected void btn_goback_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}