using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default23 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double catetoa, catetob, hipotenusa;
        catetoa = double.Parse(TextBox1.Text);
        catetob = double.Parse(TextBox2.Text);
        hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2), 0.5), 2);
        Label3.Text=("La Hipotenusa Es: "+ hipotenusa);

    }
}