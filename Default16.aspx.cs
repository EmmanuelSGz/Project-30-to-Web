using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default16 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string caracter;
        int x;
        x = 1;

        do
        {
            caracter = (TextBox1.Text);
            if (caracter.Equals("a") || (caracter.Equals("e")) ||
           (caracter.Equals("i")) || (caracter.Equals("o")) || (caracter.Equals("u"))) x = 0;
        }
        while (x == 1);
        Label2.Text = ("La Consonante Ingresada Fue : " + caracter);
    }
}