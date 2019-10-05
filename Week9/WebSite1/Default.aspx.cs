using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    List<string> fruitList = new List<string>();
    List<string> iceCreamList = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            

            fruitList.Add("Apple");
            fruitList.Add("Banana");
            fruitList.Add("Orange");

            iceCreamList.Add("Butterscotch");
            iceCreamList.Add("Chocoloate");
            iceCreamList.Add("Vanilla");
            CBLFruit.DataSource = fruitList;
            RBLIceCream.DataSource = iceCreamList;
            this.DataBind();
        }
    }

    protected void CBLFruit_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (CBLFruit.SelectedIndex >= 0)
        {
            lbl_view_area.Text = " ";
            lbl_view_area.Text = CBLFruit.SelectedItem.Text;

        }
    }
    protected void RBLIceCream_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RBLIceCream.SelectedIndex >= 0)
        {
            lbl_view_area.Text = " ";
            lbl_view_area.Text = RBLIceCream.SelectedItem.Text;
        }
            
    }
}