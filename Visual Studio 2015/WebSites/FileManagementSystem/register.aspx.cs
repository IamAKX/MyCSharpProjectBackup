using System;
using System.Configuration;
using System.Data.SqlClient;
public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String nme = TextBox1.Text;
        String email = TextBox2.Text;
        String pass = TextBox4.Text;

        String query = String.Format("insert Users values('{0}','{1}','{2}','{3}')", nme, email, pass,"0");

        String query2 = "create table " + nme + " (FileName varchar(800),Path varchar(800),Extension varchar(10))";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        cmd = new SqlCommand(query2, conn);
        cmd.ExecuteNonQuery();

        //-----Folder bnane ka code--

        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme);
        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme + "/Images");
        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme + "/Audios");
        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme + "/Videos");
        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme + "/Compressed");
        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme + "/Other");
        System.IO.Directory.CreateDirectory(Server.MapPath("DataBase") + "/" + nme + "/Trashed");

        
        Response.Write("<script>alert('hello "+nme+"!! You are successfully Registered.');</script>");
    }
}