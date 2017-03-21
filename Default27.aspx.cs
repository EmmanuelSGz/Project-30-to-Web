using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default27 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double caja, egreso, totalegresos, restocaja;
        totalegresos = 0;
        caja = 371;
        egreso = double.Parse(TextBox1.Text);
        totalegresos = totalegresos + egreso;
        restocaja = caja - totalegresos;
        if (egreso <= caja)
        {
                
                ListBox1.Items.Add("El Total De Egresos Es: " + totalegresos);
                ListBox1.Items.Add("Lo Sobrante En Caja Es: " + restocaja);
        }

    }
}