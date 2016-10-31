using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class allfiles : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        try {
            Menu m = (Menu)this.Master.FindControl("Menu1");
            m.Items[0].Text = "Hello " + Session["current_user"].ToString() + "!!";

        }
        catch
        {
            Response.Write("<script>alert('Session Expired, Please log in again...');</script>");
            Response.Redirect("Default.aspx");
        }
      
        string s = Session["current_user"].ToString();
        string query = "select FileName,Path from " + s;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        DataSet container = new DataSet();
        adapter.Fill(container);
        GridView1.DataSource = container.Tables[0];
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        String btn = e.CommandName;
        if (btn.Equals("DeleteBtn"))
        {
 
            int index = Convert.ToInt32(e.CommandArgument);
            string query = "update " + Session["current_user"].ToString() + " set Extension='trashed'";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your file has been uploaded successfully!!');</script>");
            Response.Redirect("allfiles.aspx");

        }
        else 
            if(btn.Equals("DownloadBtn"))
            {
            int index = Convert.ToInt32(e.CommandArgument);

            string source = GridView1.SelectedIndex.ToString();
            // String source = GridView1.SelectedRow.Cells[1].Text;
            Response.Write(source);
        }
    }
}