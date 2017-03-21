using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default25 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double consumo, descuento, total;
        total = 0;
            consumo = double.Parse(TextBox1.Text);
            if (consumo > 130)
            {
                descuento = consumo * 0.15;
            }
            else
            {
                descuento = 0;
            }
            consumo = consumo - descuento;
            total = total + consumo;
        ListBox1.Items.Add("El Total De Los Consumos Es: " + total);

    }
}