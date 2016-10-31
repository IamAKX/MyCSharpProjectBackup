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
    string[] extensions = { "mp3", "mp4", "avi", "ogg", "wav" ,"zip","rar"};
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string nme, extnsn;
        if (FileUpload1.HasFile)
        {

            nme = FileUpload1.FileName;

            extnsn = nme.Substring(1+nme.LastIndexOf('.'));
            foreach (string a in extensions)
            {
                if (extnsn.Equals("mp4") || extnsn.Equals("mp3") || extnsn.Equals("avi") || extnsn.Equals("ogg") || extnsn.Equals("wav"))
                {
                    Label1.Text = "Media file";
                    FileUpload1.SaveAs(Server.MapPath("Media/" + nme));
                    break;
                }
                else
                    if (extnsn.Equals("zip") || extnsn.Equals("rar"))
                    {
                        Label1.Text = "Compressed";
                        FileUpload1.SaveAs(Server.MapPath("Compressed/" + nme));
                        break;
                    }
                    else
                    {
                        Label1.Text = "Othrer Type";
                        FileUpload1.SaveAs(Server.MapPath("Others/" + nme));
                    }

            }
             

         }
          else
              Label1.Text="Nofile uploade";
  
   }
}
