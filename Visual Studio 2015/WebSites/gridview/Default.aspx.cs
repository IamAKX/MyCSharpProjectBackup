using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=gridview;Integrated Security=true");
        String query = "select * from studentinfo ";

        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        DataSet container = new DataSet();
        adapter.Fill(container);
        GridView1.DataSource = container.Tables[0];
        GridView1.DataBind();//display
     


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String id = GridView1.SelectedRow.Cells[1].Text;
        Response.Write("you selected" + id);


    }
}