using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website.service;

namespace Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void Secure_Click2(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(UserLogin.Text);
            string pass = PassLogin.Text;

            var serv = new WebService1();
            int res = serv.Login(id, pass);

            if (res == 1)
            {
                Debug.WriteLine("hola");

                Secure.Attributes.Add("href", "UserPage.aspx");
            }
            if (res == 2)
            {
                Debug.WriteLine("hola2");


                Secure.Attributes.Add("href", "AdmminPage.aspx");
            }
            if (res == 0)
            {
                Debug.WriteLine("hola0");
                Label1.Text = "Wrong password or id";
            }
        }
    }
    }
}