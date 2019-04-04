using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using Website;


namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Subject> getSubjectsXML()
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

        [WebMethod]
        public List<Student> GetStudentsXML()
        {
            List<Student> list = new List<Student>();
            SQLiteConnection conn = new SQLiteConnection("DataSource =" +  @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "SELECT Name, Age, Nationality, Password, Id FROM Student";
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            Debug.WriteLine("GG");
            DataTable dt = new DataTable();
            dt.Load(reader);
            Debug.WriteLine(dt);

            foreach(DataRow dr in dt.Rows){
                Debug.WriteLine(dt);
                Student a = new Student();
                int id = Convert.ToInt16(dr["Id"]);
                string name = dr["Name"].ToString();
                string nationality = dr["Nationality"].ToString();
                int age = Convert.ToInt16(dr["Age"]);
                string password = dr["Password"].ToString();

                Student jeje = new Student();
                jeje.Id = id;
                jeje.Name = name;
                jeje.Nationality = nationality;
                jeje.Age = age;
                jeje.Password = password;

                list.Add(jeje);

            }
            
            return list;

        }

        [WebMethod]
        public List<Professor> GetProfessorsXML()
        {
            List<Professor> list = new List<Professor>();
            SQLiteConnection conn = new SQLiteConnection("DataSource =" + @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "SELECT * FROM Professor";
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            Debug.WriteLine("GG");
            DataTable dt = new DataTable();
            dt.Load(reader);
            Debug.WriteLine(dt);

            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {

                int id = Convert.ToInt16(dr["Id"]);
                string name = dr["Name"].ToString();
                string password = dr["Password"].ToString();

                Professor jeje = new Professor();
                jeje.Name = name;
                jeje.Password = password;
                jeje.Id = id;

                list.Add(jeje);

            }

            return list;

        }
        [WebMethod]
        public int Login(int id, string password)
        {

            List<Professor> Plist = new List<Professor>();
            List<Student> Slist = new List<Student>();
            Plist = GetProfessorsXML();
            Slist = GetStudentsXML();

            for (int i = 0; i < Slist.Count; i++)
            {
                if (Slist[i].Id == id && Slist[i].Password == password )
                {
                    return 1;
                }

            }
            for (int i = 0; i < Plist.Count; i++)
            {
                if (Plist[i].Id == id && Plist[i].Password == password)
                {
                    return 2;
                }
            }
            return 0;      
        }

        [WebMethod]
        public void AddStudent(int id,string name,string nation,int age,string pass)
        {
            SQLiteConnection conn = new SQLiteConnection("DataSource =" + @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "INSERT INTO Student VALUES ('"+id+"','"+name+"','"+nation+"','"+age+"','"+pass+"');";

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.InsertCommand = comm;
            da.InsertCommand.ExecuteNonQuery();
        }


        [WebMethod]
        public void ModifyStudent(int id, int age, string pass)
        {
            
            SQLiteConnection conn = new SQLiteConnection("DataSource =" + @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "UPDATE Student SET Password ='"+pass+"',Age='"+age+"' WHERE Id = '" + id + "';";

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.UpdateCommand = comm; 
            da.UpdateCommand.ExecuteNonQuery();

        }

        [WebMethod]
        public void DeleteStudent(int id)
        {
           
            SQLiteConnection conn = new SQLiteConnection("DataSource =" + @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "DELETE FROM Student WHERE Id='"+id+"';";

            SQLiteCommand comm = new SQLiteCommand(query, conn);

            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.UpdateCommand = comm;
            da.UpdateCommand.ExecuteNonQuery();

        }
    }

    
}
