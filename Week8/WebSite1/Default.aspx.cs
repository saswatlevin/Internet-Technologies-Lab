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

            try
            {
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

        }
    }


    protected void DDLStaffId_SelectedIndexChanged(object sender, EventArgs e)
    {

        //lbl_Display.Text += LBNotify.SelectedItem.Value.ToString();
        DataSet ds = new DataSet();
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";

        try
        {
            string query = "SELECT staffid,firstname,lastname,dno,street,city,zipcode FROM dbo.house";
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
            /*
            LBNotify.DataSource = ds;
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

            //for (int i= 0;i < ds.Tables[0].Rows.Count;++i)
            //{

          lbl_Display.Text+=   ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["staffid"].ToString()+ "<br/>" + ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["firstname"].ToString()+ "<br/>" + ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["lastname"].ToString() + "<br/>" + ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["dno"].ToString()+ "<br/>" + ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["street"].ToString()+ "<br/>" + ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["city"].ToString()+ "<br/>" +  ds.Tables[0].Rows[Convert.ToInt32(DDLStaffId.SelectedIndex)]["zipcode"].ToString()+ "<br/>";

            //}
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
            int staffid = Convert.ToInt32(DDLStaffId.SelectedItem.Value);
            string city = LBNotify.SelectedItem.Value.ToString();
            string query_btn = "UPDATE dbo.house SET city=@city WHERE staffid=@staffid";
            using (SqlCommand cmd = new SqlCommand(query_btn, connection))
            {
               
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@staffid",staffid);
                connection.Open();
                int result=cmd.ExecuteNonQuery();

                //Response.Write("\nCity=" + city);
                //Response.Write("\nStaffid="+staffid);
                Response.Write("\nResult="+result);

            }
        }

    }
    
}

