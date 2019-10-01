using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {

            if (!IsPostBack)
            {
                Dictionary<string, string> genre = new Dictionary<string, string>();
                genre.Add("Comedy", "Comedy");
                genre.Add("Romance", "Romance");
                genre.Add("Animated", "Animated");
                //KeyValuePair<string, string> element;
                DDLGenre.DataSource = genre;
                DDLGenre.DataTextField = "Value";
                DDLGenre.DataValueField = "Key";
                DDLGenre.DataBind();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query_name_lb = "SELECT name FROM dbo.test";
                    using (SqlCommand cmd = new SqlCommand(query_name_lb, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = (string)reader["name"];
                                LBActors.Items.Add(name);

                            }
                        }
                    }

                }
            }
        }

        catch (Exception ex)
        {
            Response.Write("\n Error in Page_Load: " + ex);
        }
    }



    protected void DDLGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void LBActors_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query_name_select = "SELECT name,age FROM dbo.test WHERE category=@category";
                using (SqlCommand cmd = new SqlCommand(query_name_select, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@category", DDLGenre.SelectedItem.Value.ToString());
                       
                        while (reader.Read())
                        {
                            string name = (string)reader["name"];
                           
                            string age = (string)reader["age"];

                            lbl_view_area.Text += "Name " + name + "<br/>" + "Age " + "<br/>" + age;

                            /*if(category==LBActors.SelectedItem.Value.ToString())
                             {
                                 DDLGenre_SelectedIndexChanged(sender,e);
                             }*/
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write("\n Error in DDL" + ex);
        }
    }
}
        
