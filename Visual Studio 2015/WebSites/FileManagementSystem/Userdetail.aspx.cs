using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Userdetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a=0, v=0, i=0, c=0, o=0, t=0,totfile=0;
        double aa =0, vv =0 ,ii =0, cc =0, oo =0, tt = 0,totsize=0;
        string s="";
        try
        {
            s = Session["current_user"].ToString();
            Menu m = (Menu)this.Master.FindControl("Menu1");
            m.Items[0].Text = "Hello " + s + "!!";
        }
        catch
        {
            Response.Redirect("Default.aspx");
        }
        string query = "select * from " + s;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();


        while (reader.Read())
        {
            string x = reader.GetValue(2).ToString();
            if (x.Equals("images"))
                i++;
            else
                 if (x.Equals("audios"))
                        a++;
                else
                     if (x.Equals("videos"))
                        v++;
                     else
                            if (x.Equals("other"))
                               o++;
                           else
                         if (x.Equals("compressed"))
                           c++;
                         
                           else
                               if (x.Equals("trashed"))
                                   t++;
            

        }

        ii = calsize(Server.MapPath("DataBase") + "\\" + s + "\\Images")/1024;
        aa = calsize(Server.MapPath("DataBase") + "\\" + s + "\\Audios")/1024;
        vv = calsize(Server.MapPath("DataBase") + "\\" + s + "\\Videos")/1024;
        oo = calsize(Server.MapPath("DataBase") + "\\" + s + "\\Other")/1024;
        tt = calsize(Server.MapPath("DataBase") + "\\" + s + "\\Trashed")/1024;
        cc = calsize(Server.MapPath("DataBase") + "\\" + s + "\\Compressed")/1024;

        totfile = i + a + v + o + c + t;
        totsize = ii + aa + vv + oo + cc + tt;

        Label1.Text = ii + "KB";
        Label2.Text = i + " files";
        Label3.Text = aa + "KB";
        Label4.Text = a + " files";
        Label5.Text = vv + "KB";
        Label6.Text = v + " files";
        Label7.Text = cc + "KB";
        Label8.Text = c + " files";
        Label9.Text = oo + "KB";
        Label10.Text = o + " files";
        Label11.Text = tt + "KB";
        Label12.Text = t + " files";
        Label13.Text = totsize + "KB";
        Label14.Text = totfile + " files";
    }
    long calsize(string path)
    {
        DirectoryInfo di = new DirectoryInfo(path);
        return di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);

    }
}