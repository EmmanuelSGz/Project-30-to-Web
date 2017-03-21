using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double monto, descuento;
        monto = double.Parse(TextBox1.Text);

        if (monto > 100)
        {
            descuento = monto * 0.1;
            TextBox2.Text = descuento.ToString();
        }
        else if (monto <= 100 && monto > 0)
        {
            descuento = monto * 0.2;
            TextBox2.Text = descuento.ToString();
        }

    }
}