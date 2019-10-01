using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True";
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [dbo].[Table] SET price=@price WHERE flavour=@flavour";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@price",Convert.ToInt32(txt_price.Text));
                    cmd.Parameters.AddWithValue("@flavour", txt_flavour.Text);
                    int result=cmd.ExecuteNonQuery();
                    Response.Write("\n Result=" + result);
                }
            }
        }

        catch(Exception ex)
        {
            Response.Write("\n Error:" + ex);
        }
    }
}