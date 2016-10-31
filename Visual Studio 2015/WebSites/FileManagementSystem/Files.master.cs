using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Files : System.Web.UI.MasterPage
{
    string unm;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*string str = Menu1.Items[0].Text;
        unm = str.Substring(str.IndexOf(' ') + 1);*/

        // unm = HiddenField1.Value;
        unm = Session["current_user"].ToString();
        Menu1.Items[0].Value = unm;
    }

    
    //string[] extensions = { "mp3", "mp4", "avi", "ogg","mkv","flv", "gif","wmb" ,"mpeg","3gp","aac","png","jpg","amr","bmp","wav", "zip", "rar","tar","iso","7z","dmg" };


    protected void Button1_Click(object sender, EventArgs e)
    {
        string nme, extnsn,path,query="";
        if (FileUpload1.HasFile)
        {

            nme = FileUpload1.FileName;

            extnsn = nme.Substring(1 + nme.LastIndexOf('.'));
            
                if (extnsn.Equals("mp4") || extnsn.Equals("mkv") || extnsn.Equals("avi") || extnsn.Equals("flv") || extnsn.Equals("3gp") || extnsn.Equals("mpeg"))
                {
                //Videos
                path = Server.MapPath("DataBase") + "\\" + unm + "\\Videos\\" + nme;
                FileUpload1.SaveAs(path);
                 query = String.Format("insert " + unm + " values ('{0}','{1}','{2}')", nme, path, "videos");
            }
                else
                if (extnsn.Equals("mp3") || extnsn.Equals("ogg") || extnsn.Equals("wmb") || extnsn.Equals("aac") || extnsn.Equals("amr") || extnsn.Equals("wav"))
                {
                //Audios
                path = Server.MapPath("DataBase") + "\\" + unm + "\\Audios\\" + nme;
                FileUpload1.SaveAs(path);
                 query = String.Format("insert " + unm + " values ('{0}','{1}','{2}')", nme, path, "audios");
            }
                else
                if (extnsn.Equals("gif") || extnsn.Equals("png") || extnsn.Equals("jpg") || extnsn.Equals("bmp"))
                {
                    // Images
                    path = Server.MapPath("DataBase")+"\\"+unm+"\\Images\\"+nme;
                    FileUpload1.SaveAs(path);
                     query = String.Format("insert " + unm + " values ('{0}','{1}','{2}')", nme, path, "images");
            }
                else
                if (extnsn.Equals("iso") || extnsn.Equals("zip") || extnsn.Equals("rar") || extnsn.Equals("7z") || extnsn.Equals("tar") || extnsn.Equals("dmg"))
                {
                // Compressed
                path = Server.MapPath("DataBase") + "\\" + unm + "\\Compressed\\" + nme;
                FileUpload1.SaveAs(path);
                 query = String.Format("insert " + unm + " values ('{0}','{1}','{2}')", nme, path, "compressed");
            }
                else
                {
                    // others
                    path = Server.MapPath("DataBase")+"\\"+unm+"\\Other\\"+nme;
                    FileUpload1.SaveAs(path);
                 query = String.Format("insert " + unm + " values ('{0}','{1}','{2}')", nme, path, "other");
            }



               
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Your file has been uploaded successfully!!');</script>");
            Response.Redirect("allfiles.aspx");
        }


    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        String s = TextBox1.Text;
        string query = "select * from " + unm ;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();


        while (reader.Read())
        {

            string x = reader.GetValue(0).ToString();
            x = x.Substring(0, x.LastIndexOf('.'));
            if (s.Equals(x))
            {
                string y = reader.GetValue(2).ToString();
                if (y.Equals("images"))
                    Response.Redirect("images.aspx");
                else
                     if (y.Equals("audios"))
                        Response.Redirect("audios.aspx");
                else
                         if (y.Equals("videos"))
                            Response.Redirect("videos.aspx");
                else
                                if (y.Equals("other"))
                                    Response.Redirect("other.aspx");
                else
                             if (y.Equals("compressed"))
                    Response.Redirect("Compressed.aspx");

                else
                                   if (y.Equals("trashed"))
                                         Response.Redirect("trashed.aspx");


            }
        }
    }
}
