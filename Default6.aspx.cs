using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int x, numero, suma;
        numero = int.Parse(TextBox1.Text);
        suma = 0;
        for (x = 1; x <= numero; x = x + 1)
        {
            suma = suma + x;
            Label2.Text = ("N "+ x +" : "+ x);
        }
        Label3.Text = ("La Suma De La Serie Es : "+ suma);

    }
}