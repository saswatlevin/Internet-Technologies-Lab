using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    List<string> category = new List<string>();
    string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            category.Add("Animated");
            category.Add("Comedy");
            category.Add("Romance");

            DDLCategory.DataSource = category;
            this.DataBind();

           

            
        }
    }

    protected void DDLCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT name FROM dbo.actor WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", DDLCategory.SelectedIndex);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = (string)reader["name"];
                            LBNames.Items.Add(name);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write("\n Error " + ex);
        }
    }
    protected void LBNames_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}