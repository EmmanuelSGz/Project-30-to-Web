using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default21 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double num1, num2, suma, resta, multiplicacion, division;
            num1 = double.Parse(TextBox1.Text);
        if (num1 != 0)
        {
            num2 = double.Parse(TextBox2.Text);
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = Math.Round(num1 / num2, 2);
            ListBox1.Items.Add("PROCESO : ");
            ListBox1.Items.Add("La Suma Es: " + suma);
            ListBox1.Items.Add("La Resta Es : " + resta);
            ListBox1.Items.Add("La Multilicacion Es: " + multiplicacion);
            ListBox1.Items.Add("La Division Es: " + division);
        }
        else {
            ListBox1.Items.Add("FINAL DEL PROCESO...");
        }
        
    }
}