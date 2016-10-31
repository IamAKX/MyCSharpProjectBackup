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
        addnum();
    }
    public void addnum()
    {
        int num1 = Convert.ToInt32(TextBox1.Text);
        int num2 = Convert.ToInt32(TextBox2.Text);
        TextBox3.Text = (num1 + num2).ToString();
        //System.Threading.Thread.Sleep(10000);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        addnum();
    }
}