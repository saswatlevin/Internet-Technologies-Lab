using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query_insert = "INSERT INTO dbo.works(person_name,company_name,salary) VALUES(@person_name,@company_name,@salary)";

                using (SqlCommand cmd = new SqlCommand(query_insert, connection))
                {
                    cmd.Parameters.AddWithValue("@person_name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@company_name", txt_company_name.Text);
                    cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txt_salary.Text));
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    Response.Write("\n Insert Result= " + result);
                }
            }

            
               
            }
            catch (Exception ex)
            {
                Response.Write("\n Error in Insert" + ex);
            }

        try
        {
            using (SqlConnection con1 = new SqlConnection(connectionString))
            {
                string query_update_lives = "INSERT INTO dbo.lives(person_name) VALUES(@person_name)";
                using (SqlCommand cmd_1 = new SqlCommand(query_update_lives, con1))
                {
                    cmd_1.Parameters.AddWithValue("@person_name", txt_name.Text);
                    con1.Open();
                    int result_1 = cmd_1.ExecuteNonQuery();
                    Response.Write("\n Update_lives_Result= " + result_1);
                }
            }
        }
        catch(Exception ex)
        {
            Response.Write("\n Error in Update lives"+ex);
        }
    }

    protected void btn_get_details_Click(object sender, EventArgs e)
    {
        int result;
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query_get_details = "SELECT works.person_name,lives.city FROM works,lives WHERE works.person_name=@person_name AND works.person_name=lives.person_name";
               
                using (SqlCommand cmd = new SqlCommand(query_get_details, connection))
                {
                    cmd.Parameters.AddWithValue("@person_name",txt_name.Text);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           //Debug.WriteLine("{0}\t{1}", reader.GetString(0), reader.GetString(1));
                            //string name = (string)rdr["works.person_name"];
                            //string city = (string)rdr["lives.city"];
                            lbl_view_area.Text += "Name " + reader.GetString(0) +"\t"+ "City " + reader.GetString(1);                       }
                    }
                }
            }
           
        }
        
        catch(Exception ex)
        {
            Response.Write("\n Error in getting details " + ex);
        }
    }
}