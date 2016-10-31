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
        if (!Page.IsPostBack)
        {
            Panel1.Visible = false;
            for (int i = 2016; i <= 2099; i++)
            {
                DropDownList2.Items.Add(i.ToString());
            }
            string[] ar = { "PNB", "SBI", "Central Bank of India", "UBI", "IDBI", "ICICI", "Axis Bank", "HDFC" };
            foreach (string s in ar)
                DropDownList1.Items.Add(s);
            for(int i=1 ;i<=12;i++)
                DropDownList3.Items.Add(i.ToString());
        }

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
      
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
            Button4.Visible = true;
        else
            if(RadioButton2.Checked==true)
            {
                Button4.Visible = true;
                Panel1.Visible = true;
            }
            else
            {
                Button4.Visible = false;
                Panel1.Visible = false;
            }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        double total = 0;
        string s = "";
        if (CheckBox1.Checked)
        {
            total += 75;
            s += "4 Bread with rich butter and milk<br/>";
        }
        if (CheckBox2.Checked)
        {
            total += 105;
            s += "4 Bread with jam,1 juice,1 boiled egg<br/>";
        }
        if (CheckBox3.Checked)
        {
            total += 60;
            s += "Corn flakes, 1 glass milk and 1 juice<br/>";
        }
        if (CheckBox4.Checked)
        {
            total += 130;
            s += "Hakka noodles and chicken manchurian<br/>";
        }
        if (CheckBox5.Checked)
        {
            total += 100;
            s += "Special Masala Dosa<br/>";
        }
        if (CheckBox6.Checked)
        {
            total += 110;
            s += "Butter Nan, Shahi Paneer and Dal Makhani<br/>";
        }
        if (CheckBox7.Checked)
        {
            total += 90;
            s += "Masala kulcha and Chilli Paneer<br/>";
        }
        if (CheckBox8.Checked)
        {
            total += 65;
            s += "Chole with 4 Bhature<br/>";
        }
        if (CheckBox9.Checked)
        {
            total += 110;
            s += "Gravy Noodles<br/>";
        }
            Label1.Text = "Rs. "+total.ToString();
            Label5.Text = s;
            Label6.Text = "Rs. " + total.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Text = TextBox1.Text;
        Label3.Text = TextBox2.Text;
        Label4.Text = TextBox3.Text;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
            Label7.Text = "Payment done through COD";
        else
            Label7.Text = "Payment done via Card Number : "+TextBox5.Text+" Card owner : "+TextBox4.Text;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}