using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default14 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double suma, media, x, numero; suma = 0;
        for (x = 1; x <= 100; x = x + 1)
        {
            x = double.Parse(TextBox1.Text);
            numero = double.Parse(TextBox2.Text);
            suma = suma + numero;
        }
        media = Math.Round(suma / 100, 2);
        Label2.Text = ("La Media De Los 100 Numero Ingresados Es: " + media);

    }
}