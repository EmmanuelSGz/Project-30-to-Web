using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int tiempo, dias, horas, minutos, x;
        tiempo = int.Parse(TextBox1.Text);

        if (tiempo >= 0)
        {
            dias = (tiempo - (tiempo % 60)) / 1440;
            x = tiempo % 1440;
            horas = (x - (x % 60)) / 60;
            minutos = x % 60;
            Label2.Text = ("Equivale A" + dias +" Dias Con "+ horas +"Horas Y "+ minutos +" Minutos");
        }
        else
        {
            Label2.Text = ("El Tiempo No Puede Ser Negativo...");
        }


    }
}