using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double horastrabajadas, tarifa, salario;
        horastrabajadas = double.Parse(TextBox1.Text);
        tarifa = double.Parse(TextBox2.Text);
        salario = horastrabajadas * tarifa;

        Label3.Text = ("El Salario Del Trabajador Es: " + salario);
    }
}