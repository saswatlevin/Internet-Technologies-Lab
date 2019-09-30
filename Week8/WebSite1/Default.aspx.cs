using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";
    
    protected void Page_Load(object sender, EventArgs e)
    {

        string query = "SELECT staffid,firstname,lastname,dno,street,city,zipcode FROM dbo.house";
        if (!IsPostBack)
        {
            LBNotify.Items.Add("Delhi");
            LBNotify.Items.Add("Chennai");
            LBNotify.Items.Add("Chandigarh");

            try {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {   
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query,connection))
                        {
                            adapter.Fill(ds);
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                Response.Write("\n Error: " + ex);
            }

            try
            {
                DDLStaffId.DataSource = ds;
                DDLStaffId.DataTextField = "staffid";
                DDLStaffId.DataValueField = "staffid";
                DDLStaffId.DataBind();
                /*LBNotify.DataSource = ds;
                LBNotify.DataTextField = "city";
                LBNotify.DataValueField = "city";
                LBNotify.DataBind();*/



            }

            catch (Exception ex)
            {
                Response.Write("\n Data Error: " + ex);
            }

        }
    }


    protected void DDLStaffId_SelectedIndexChanged(object sender, EventArgs e)
    {

        DataSet ds = new DataSet();
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";
        
        try
        {
            string query = "SELECT staffid FROM dbo.house";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(ds);
                    }
                }
            }

        }
        catch (Exception ex)
        {
            Response.Write("\n Error: " + ex);
        }

        try
        {
            DDLStaffId.DataSource = ds;
            DDLStaffId.DataTextField = "staffid";
            DDLStaffId.DataValueField = "staffid";
            DDLStaffId.DataBind();
            /*LBNotify.DataSource = ds;
            LBNotify.DataTextField = "city";
            LBNotify.DataValueField = "city";
            LBNotify.DataBind();*/



        }

        catch (Exception ex)
        {
            Response.Write("\n Data Error: " + ex);
        }


        try
            {

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                lbl_Display.Text += ds.Tables["dbo.house"].Rows[0]["staffid"].ToString() + "<br />";
            }
            //Response.Write("\n Selected");
            }
            catch (Exception ex)
            {
                Response.Write("\nDataRow Error in foreach: " + ex);
            }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {   
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query_btn = "UPDATE dbo.house SET city=@city WHERE staffid=@staffid";
            using (SqlCommand cmd = new SqlCommand(query_btn, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@city", LBNotify.SelectedIndex);
                cmd.Parameters.AddWithValue("@staffid", DDLStaffId.SelectedIndex);
            }
        }

    }
        
}