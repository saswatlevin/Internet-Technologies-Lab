using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Dictionary<int, string> states = new Dictionary<int, string>();
    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";
    DataSet ds = new DataSet(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            /*try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT cityname FROM dbo.city";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        //cmd.Parameters.AddWithValue("@stateid",DDLState.SelectedIndex);
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
                Response.Write("\nError in getting bulk data "+ex);
            }*/

            try
            {
                states.Add(1, "Andhra Pradesh");
                states.Add(2, "Bihar");
                states.Add(3, "Chhattisgarh");
                states.Add(4, "Himachal Pradesh");
                states.Add(5, "Manipur");

                DDLState.DataSource = states;
                DDLState.DataTextField = "Value";
                DDLState.DataValueField = "Key";
                this.DataBind();

                /*DDLCity.DataSource = ds;
                DDLCity.DataTextField = "cityname";
                DDLCity.DataValueField = "cityname";
                DDLCity.DataBind();*/
            }
             catch(Exception ex)
             {
                Response.Write("\n Error in databinding DDLs " + ex);
             }   
            
        }
    }

    protected void DDLState_SelectedIndexChanged(object sender, EventArgs e)
    {  
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT cityname FROM dbo.city WHERE stateid=@stateid";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@stateid", DDLState.SelectedIndex);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string cityname = (string)reader["cityname"];
                        DDLCity.Items.Add(cityname);
                    }
                }
            }
        }
    }

    protected void DDLCity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}