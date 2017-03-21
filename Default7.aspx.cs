using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double x, salario, horastrabajadas, tarifa, suma, numerotrabajadores;
        suma = 0;
        numerotrabajadores = double.Parse(TextBox1.Text);

        for (x = 1; x <= numerotrabajadores; x = x + 1)
        {
            Label2.Text = ("Trabajador  "+ x +": ");
            Label3.Text = ("Horas Trabajasdas : ");
            Label4.Text = ("Tarifa : ");

            //salario = horastrabajadas * tarifa;
            //suma = suma + salario;

        }
        Label5.Text = ("La Suma De Los Salarios Es : "+ suma);

    }
}