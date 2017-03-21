using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default19 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double num1, num2, c, suma, resta, multiplicacion, division; c = 0;
        do
        {
            c = c + 1;
            Label1.Text = ("PROCESO Nº"+ c +" :");
            num1 = double.Parse(TextBox1.Text);
            num2 = double.Parse(TextBox2.Text);
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = Math.Round(num1 / num2, 2);

            Label4.Text = ("La Suma Es: " + suma);
            Label5.Text = ("La Resta Es : " + resta);
            Label6.Text = ("La Multiplicacion Es: " + multiplicacion);
            Label7.Text = ("La Division Es: " + division);
        } while (c <= 9);
        Label8.Text = ("Final Del Proceso");

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}