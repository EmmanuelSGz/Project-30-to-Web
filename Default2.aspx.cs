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
        double sueldo, sueldoneto, descuento;
        sueldo = double.Parse(TextBox1.Text);

        if (sueldo <= 1000 && sueldo >= 0)
        {
            descuento = sueldo * 0.1;
            sueldoneto = sueldo - descuento;
            TextBox2.Text = descuento.ToString();
            TextBox3.Text = sueldoneto.ToString();
        }
        else if (sueldo <= 2000 && sueldo >= 0)
        {
            descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
            sueldoneto = sueldo - descuento;
            TextBox2.Text = descuento.ToString();
            TextBox3.Text = sueldoneto.ToString();
        }
        else if (sueldo > 2000)
        {
            descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
            sueldoneto = sueldo - descuento;
            TextBox2.Text = descuento.ToString();
            TextBox3.Text = sueldoneto.ToString();
        }

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}