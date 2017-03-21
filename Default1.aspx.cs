using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double tarifa, horastrabajadas, horasextra, salario, tarifaextra;
        horastrabajadas = double.Parse(TextBox1.Text);
        tarifa = double.Parse(TextBox2.Text);

        if (horastrabajadas <= 40 && horastrabajadas >= 0)
        {
            salario = horastrabajadas * tarifa;
            TextBox3.Text = salario.ToString();
        }
        else if (horastrabajadas > 40)
        {
            horasextra = horastrabajadas - 40;
            tarifaextra = tarifa + 0.5 * tarifa;
            salario = horasextra * tarifaextra + 40 * tarifa;
            TextBox3.Text = salario.ToString();
        }
            
    }
}