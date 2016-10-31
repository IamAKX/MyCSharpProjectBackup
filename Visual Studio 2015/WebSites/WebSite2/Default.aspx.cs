using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double p, r, t;
        p=Convert.ToDouble(TextBox2.Text);
        r=Convert.ToDouble(TextBox1.Text);
        t=Convert.ToDouble(TextBox3.Text);
        double res = p * r * t / 100;
        TextBox4.Text = res.ToString();
    }
}