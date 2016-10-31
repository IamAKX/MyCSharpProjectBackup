using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;

public partial class forget : System.Web.UI.Page
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
        string uname = TextBox2.Text;

        String query = String.Format("select * from Users where Name='{0}' and Email = '{1}'", uname, email);
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            string pass = reader.GetValue(2).ToString();
            Response.Write("<Script>alert('Your Password :"+pass+"');</script>");
           
        }
        else
        {
            Response.Write("<Script>alert('Sorry, Your are registered yet.');</script>");
        }
    }
}