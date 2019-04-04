using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website.webservice;

namespace Website.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var serv = new WebService1();
            List<Student> listS = new List<Student>();
            ListBox2.Items.Clear();

            listS = serv.GetStudentsXML().ToList();
            for (int i=0;i<listS.Count;i++)
            {
                ListBox2.Items.Add("Name: "+listS[i].Name +" |----| Id: "+listS[i].Id.ToString() 
                    + " |----| Age: " + listS[i].Age + " |----| Password: " + listS[i].Password);
            }

            int index = ListBox2.SelectedIndex;
            if (index != -1)
            {
                TextBox6.Text = listS[index].Age.ToString();
                TextBox7.Text = listS[index].Password;
                TextBox8.Text = listS[index].Id.ToString();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;

            string pass = TextBox4.Text;
            string nationality = TextBox5.Text;

            var serv = new WebService1();
            if (TextBox2.Text != "" && TextBox3.Text != ""){

                int id = Convert.ToInt16(TextBox2.Text);
                int age = Convert.ToInt16(TextBox3.Text);
                serv.AddStudent(id, name, nationality, age, pass);
            }      
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var serv = new WebService1();
            serv.DeleteStudent(Convert.ToInt16(TextBox8.Text.ToString()));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var serv = new WebService1();
            if( TextBox8.Text != "" && TextBox6.Text != "")
            {
                serv.ModifyStudent(Convert.ToInt16(TextBox8.Text.ToString()),
                Convert.ToInt16(TextBox6.Text.ToString()),
                TextBox7.Text.ToString());
            }
        }
    }
}