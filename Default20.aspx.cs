using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default20 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double numero, cubo, raizcuadrada;
            numero = double.Parse(TextBox1.Text);
        if (numero < 0 || numero > 0)
        {

            cubo = Math.Pow(numero, 3);
            raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
            ListBox1.Items.Add("PROCESO :");
            ListBox1.Items.Add("\nEl Cubo Es: " + cubo);
            ListBox1.Items.Add("\nLa Raiz Cuadrada Es: " + raizcuadrada + "\n");

        }
        else {
            ListBox1.Items.Add("Fin De Proceso...");
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}