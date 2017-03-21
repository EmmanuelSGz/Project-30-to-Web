using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default28 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double nota1, nota2, promedio;
        nota1 = double.Parse(TextBox1.Text);
        nota2 = double.Parse(TextBox2.Text);
        promedio = (nota1 + nota2) / 2; if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
        {
            if (promedio >= 10.5 && promedio <= 20)
            {
                ListBox1.Items.Add("Promedio: " + promedio);
                ListBox1.Items.Add("Aprobado");
            }
            else
            {
                ListBox1.Items.Add("Promedio: " + promedio);
                ListBox1.Items.Add("Desaprobado");
            }
        }
        else
        {
            ListBox1.Items.Add("ERROR... Las notas ingresadas no se encuentran en la escala vigesimal(0 - 20)");
    }

    }
}