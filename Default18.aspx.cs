using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default18 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double coefA, coefB, coefC, disc, s1, s2, s3, raiz1, raiz2, raizima1,raizima2;

        coefA = double.Parse(TextBox1.Text);
        coefB = double.Parse(TextBox2.Text);
        coefC = double.Parse(TextBox3.Text);
        disc = (Math.Pow(coefB, 2) - 4 * coefA * coefC);

        if (coefA == 0)
        { 
            Label5.Text = ("Esta No Es Una Ecuacion Cuadratica Coeficiente 'a' Debe Ser Diferente De 0") ; 
            }
        else if ( disc >  0)
        {
            s1 = Math.Round((-coefB + Math.Pow(disc, 0.5)) / (2 * coefA), 2);
            s2 = Math.Round((-coefB - Math.Pow(disc, 0.5)) / (2 * coefA), 2);
            Label5.Text = ("El Discriminante Es Positivo y Se Han Obtenido Las Siguientes Soluciones: x1 = "+ s1 +" y x2 = "+ s2);
            }
        else if (disc == 0)
        {
            s3 = Math.Round((-coefB / (2 * coefA)), 2);
            Label5.Text = ("El Discriminante Es 0 Se Obtiene La Siguiente Solucion: s = "+ s3);
        }
        else if ((4 * coefA * coefC) > (Math.Pow(coefB, 2)))
        {
            raiz1 = Math.Round(-coefB / (2 * coefA), 3);
            raizima1 = Math.Round(Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB,2)) / (2 * coefA), 4);
            raiz2 = Math.Round(-coefB / (2 * coefA), 3);
            raizima2 = Math.Round(-Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB,2)) / (2 * coefA), 4);
            Label5.Text = ("El Discrimiante Es "+ disc +" Se Obtienen Las Siguientes Raices Imaginarias: x1 = "+ raiz1 +" +i("+raizima1+") , x2 = "+raiz2+" +i("+raizima2+")");
        }

        }
    }