using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
     }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string email = TextBox1.Text;
        string pass = TextBox2.Text;

        String query = String.Format("select * from Users where Email='{0}' and Pass = '{1}'", email,pass);
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
       conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            string uname = reader.GetValue(0).ToString();
            Session["current_user"] = uname;
            Response.Redirect("allfiles.aspx?uname="+uname);
        }
        else
        {
            Response.Write("<Script>alert('Oopppss!! Wrong e-Mail ID or Password.');</script>");
        }

        
    }
}