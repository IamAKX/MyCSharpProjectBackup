using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


public partial class enquiry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string num = TextBox2.Text;
        string msg = TextBox3.Text;
        string msgbody = "<h2>Dear Admin</h2>,<br/>" +
                    "Costomer name : " + name + "<br/>" +
                     "Customer phone : " + num + "<br/" +
                     "Message :" + msg;
         SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
            client.Credentials = new NetworkCredential("superkol2016@gmail.com", "mta@123#");
            client.EnableSsl = true;
            MailMessage mail = new MailMessage("superkol2016@gmail.com", "akx.sonu@gmail.com");
            mail.Subject = "Asp.net mail testing";
            mail.Body = msgbody;
            mail.IsBodyHtml = true;
            client.Send(mail);
            Response.Write("<script>alert('mail sent successfully');</script>");
           }
}