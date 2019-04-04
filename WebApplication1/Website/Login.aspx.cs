using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website.webservice;

namespace Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        public void Secure_Click2(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string pass = Password.Text.ToString();

            var serv = new WebService1();
           
            if( pass!= "" && User.Text.ToString() != "")
            {
                int id = Convert.ToInt16(User.Text.ToString());
                int res = serv.Login(id, pass);

                if (res == 1)
                {
                    Debug.WriteLine("hola");

                    //  Button1.Attributes.Add("href", "UserPage.aspx");
                    Response.Redirect("Secured/UserPage.aspx");
                }
                if (res == 2)
                {
                    Debug.WriteLine("hola2");
                    Response.Redirect("Admin/AdminPage.aspx");

                    // Button1.Attributes.Add("href", "AdmminPage.aspx");
                }
                if (res == 0)
                {
                    Debug.WriteLine("hola0");
                    Label1.Text = "Wrong password or id";
                }
            }
            else
            {
                Label1.Text = "Wrong password or id";
            }
        }
    }
}