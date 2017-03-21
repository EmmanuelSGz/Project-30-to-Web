using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default22 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double ladoa, ladob, ladoc, sm, areatriangulo;
       
        ladoa = double.Parse(TextBox1.Text);
        ladob = double.Parse(TextBox2.Text);
        ladoc = double.Parse(TextBox3.Text);
        sm = (ladoa + ladob + ladoc) / 2;
        areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm* (sm - ladoc), 0.5), 2);
        Label4.Text=("El Area Del Triangulo Es: " + areatriangulo);

    }
}