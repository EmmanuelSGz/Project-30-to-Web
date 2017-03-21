using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default11 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double precio, numeroarticulos, precioventa, descuento, preciobruto, iva, totalpagar;
        precio = double.Parse(TextBox1.Text);
        numeroarticulos = double.Parse(TextBox2.Text);
        precioventa = precio * numeroarticulos;
        iva = Math.Round(precioventa * 0.15, 2);
        preciobruto = precioventa + iva;

        if (preciobruto >= 50)
        {
            descuento = Math.Round((preciobruto * 5) / 100, 2);
        }
        else
        {
            descuento = 0;
        }

        totalpagar = preciobruto - descuento;
        Label3.Text = (" [Datos De La Factura] ");
        Label4.Text = (" Precio De Venta : " + precioventa);
        Label5.Text = (" Impuesto Sobre El Valor Añadido (IVA) Es: " + iva);
        Label6.Text = (" Precio Bruto Es : " + preciobruto);
        Label7.Text = (" Descuento Es : " + descuento);
        Label8.Text = (" Total A Pagar : " + totalpagar);

    }
}