using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website;
using Website.webservice;

namespace Website.Secured
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var serv = new WebService1();
            List<Subject> listS = new List<Subject>();
            ListBox2.Items.Clear();

            listS = getSubjectsXML();
            for (int i = 0; i < listS.Count; i++)
            {
                ListBox2.Items.Add("Title: " + listS[i].Title + " |----| Id: " + listS[i].Id.ToString()
                    + " |----| Credits: " + listS[i].Credits.ToString() );
            }

            List<Student> listI = new List<Student>();
            ListBox1.Items.Clear();

            listI = serv.GetStudentsXML().ToList();
            for (int i = 0; i < listS.Count; i++)
            {
                ListBox1.Items.Add("Name: " + listI[i].Name + " |----| Id: " + listI[i].Id.ToString()
                    + " |----| Age: " + listI[i].Age );
            }




        }

        private List<Subject> getSubjectsXML()
        {
            List<Subject> list = new List<Subject>();
            SQLiteConnection conn = new SQLiteConnection("DataSource =" + @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "SELECT * FROM Subject";
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);


            foreach (DataRow dr in dt.Rows)
            {
                Debug.WriteLine(dt);
                Student a = new Student();
                int id = Convert.ToInt16(dr["Id"]);
                string title = dr["Title"].ToString();
                int cred = Convert.ToInt16(dr["Credits"]);


                Subject sub = new Subject();
                sub.Id = id;
                sub.Title = title;
                sub.Credits = cred;

                list.Add(sub);

            }

            return list;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
    }
}