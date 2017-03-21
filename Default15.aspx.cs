using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default15 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int suma, producto, x; suma = 0; producto = 1;
        for (x = 20; x <= 30; x = x + 2)
        {
            suma = suma + x;
            producto = producto * x;
        }
        Label2.Text = ("La Suma Es: " + suma);
        Label3.Text = ("El Producto Es: " + producto);
    }
}