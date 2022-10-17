using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oct3ass
{
    public partial class firstpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label1.Text = Session.SessionID.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            if (TextBox2.Text == "bhuvana@gmail.com" && TextBox2.Text == "bhuvi@1234")
            {
                Response.Write("you logged in successfully");
            }
            else
            {
                Response.Write("Invalid userid/psw");
            }



            string username = TextBox2.Text;
            Session["uname"] = username;
            Response.Redirect("~/logintable.aspx");
        }
    }
}