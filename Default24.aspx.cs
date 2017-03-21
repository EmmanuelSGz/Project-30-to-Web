using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default24 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double pi, radio, area, volumen, longitud; pi = 3.14;
        radio = int.Parse(TextBox1.Text);
        longitud = 2 * pi * radio; area = Math.Round(pi * Math.Pow(radio, 2), 2);
        volumen = Math.Round((4 / 3) * pi * Math.Pow(radio, 3), 2);
        Label2.Text=("Longitud de la Circunferencia: " + longitud);
        Label3.Text=("Area de la Circunferencia: " + area);
        Label4.Text=("Volumen de la Circunferencia: " + volumen);
    }
}