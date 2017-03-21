using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default29 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string deporte;
        int vole, fut, aje, basq, c; vole = 0; fut = 0; aje = 0; basq = 0; c = 0;

        do
        {
           c = c+1;
           deporte = (TextBox1.Text);
        if (deporte == "voley")
        {
            vole = vole+1;
        }
        else if (deporte == "futbol")
        { 
            fut = fut+1;
        }
        else if (deporte == "basquet")
        { 
            basq = basq+1; 
        }
        else if (deporte == "ajedrez")
        { 
            aje = aje+1; 
        }
        else
        {
            ListBox1.Items.Add("Error deporte no valido");
        }
                
            } while (c <= 10);
        Label3.Text=("Cantidad de voley: " + vole); 
        Label4.Text=("Cantidad de futbol: " + fut);
        Label5.Text=("Cantidad de basquet: " + basq);
        Label6.Text=("Cantidad de ajedrez: " + aje);

        }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
