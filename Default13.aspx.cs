using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default13 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int numero, factorial, i;
        numero = int.Parse(TextBox1.Text);
        factorial = 1;

        for (i = 1; i <= numero; i++)
        {
            factorial = factorial * i; //factorial *= i
            Label2.Text = ("Factorial: ");
            Label3.Text = (" "+ numero +"! = "+factorial);
        }
    }
}