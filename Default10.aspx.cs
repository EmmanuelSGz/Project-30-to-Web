using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default10 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int numero, suma, residuo; suma = 0;
        numero = int.Parse(TextBox1.Text);

        do
        {
            residuo = numero % 10;
            suma = suma + residuo;
            numero = (numero - (numero % 10)) / 10;
        }
        while (numero != 0);
        {
            Label2.Text = ("La Suma De Los Digitos Es : "+ suma);
        }
        
    }
}