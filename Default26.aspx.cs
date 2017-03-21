using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default26 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        int numero, suma, x;
        suma = 0;
        numero = int.Parse(TextBox1.Text);
        if ( numero <  8)
        {
            ListBox1.Items.Add("Error el Numero Ingresado es Menor a 8");
        }
        else {
            
            for ( x = 8; x <= numero; x = x +  1)
            {
                suma = suma + x;
                ListBox1.Items.Add("La Suma de la Serie de Rango 8 Hasta" + numero + ", Con un Incremento De 1 es: " + suma);
            }
            ListBox1.Items.Add("\n");
        }

    }
}