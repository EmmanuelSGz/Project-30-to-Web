using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int tiemposegundos, minutos, segundosrestantes;
        tiemposegundos = int.Parse(TextBox1.Text);

        if (tiemposegundos < 60 && tiemposegundos > 0)
        {
            segundosrestantes = 60 - tiemposegundos;
            Label2.Text = ("Le Falta" + segundosrestantes + "Segundos Para Convertirse A Otro Minuto");
        }
        else if (tiemposegundos >= 60)
        {
            minutos = (tiemposegundos - (tiemposegundos % 60)) / 60;
            segundosrestantes = tiemposegundos % 60;
            Label2.Text = ("Equivale A " + minutos + " Minutos y Le Faltan " + segundosrestantes + " Segundos Para Convertirse A Otro Minuto");
        }
        else if (tiemposegundos < 0)
        {
            Label2.Text = ("No Se Calculan Valores Negativos...");
        }
    }
}