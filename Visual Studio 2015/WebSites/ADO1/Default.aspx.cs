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

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = TextBox1.Text;
        string name = TextBox2.Text;
        string course = TextBox3.Text;
        
        String query = String.Format("insert studentinfo values({0},'{1}','{2}')", id, name, course);
        QueryChalao(query, "Added successfully");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string id = TextBox1.Text;


        String query = String.Format("delete from studentinfo where studentid={0}", id);
        QueryChalao(query, "deleted successfully");
    }
    void QueryChalao(String query, String msg)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('"+msg+"');</script>");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string id = TextBox1.Text;


        String query = String.Format("select * from studentinfo where studentid={0}", id);
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();
        if(reader.Read())
        {
            TextBox2.Text = reader.GetValue(1).ToString();
            TextBox3.Text = reader.GetValue(2).ToString();
        }
        else
        {
            Response.Write("<Script>alert('no row found');</script>");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string query = "update studentinfo set name='"
            + TextBox2.Text + "', course='"
            + TextBox3.Text + "' where studentid="
            + TextBox1.Text;

        QueryChalao(query,"Data updated successfully");

    }
}