﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default17 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double numero, pf;
        numero = double.Parse(TextBox1.Text);
        pf = Math.Truncate(numero);

        if (numero == pf)
        {
            Label2.Text = ("No Tiene Parte Fraccionaria...");
        }
        else
            Label2.Text = ("Tiene Parte Fraccionaria...");

    }
}