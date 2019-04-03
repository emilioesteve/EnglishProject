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
        public Student[] GetStudentsXML()
        {
            Student[] list = new Student[30];
            SQLiteConnection conn = new SQLiteConnection("DataSource =" +  @"C:\Users\jcarr\Documents\GitHub\EnglishProject\project.db" + "; Version = 3");
            conn.Open();
            String query = "SELECT Name, Age, Nationality, Password, Id FROM Student";
            SQLiteCommand comm = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = comm.ExecuteReader();
            Debug.WriteLine("GG");
            DataTable dt = new DataTable();
            dt.Load(reader);
            Debug.WriteLine(dt);

            int i = 0;
            foreach(DataRow dr in dt.Rows){
                Debug.WriteLine(dt);
                Student a = new Student();
                int id = Convert.ToInt16(dr["Id"]);
                string name = dr["Name"].ToString();
                string nationality = dr["Nationality"].ToString();
                int age = Convert.ToInt16(dr["Age"]);
                string password = dr["Password"].ToString();

                list[i] = new Student()
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    Password = password,
                    Nationality = nationality
                };
                    
                i++;

            }
            
            return list;

        }

        [WebMethod]
        public Professor[] GetProfessorsXML()
        {
            Professor[] list = new Professor[30];
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

                list[i] = new Professor()
                {
                    Id = id,
                    Name = name,
                    Password = password
                };

                i++;

            }

            return list;

        }
        [WebMethod]
        public int Login(int id, string password)
        {

            Student[] listS = new Student[30];
            Professor[] listP = new Professor[30];

            listS = GetStudentsXML();

            List<Professor> Plist = new List<Professor>();
            List<Student> Slist = new List<Student>();
            listP = GetProfessorsXML();

            Plist = listP.ToList();
            Slist = listS.ToList();
            for (int i = 0; i < 2; i++)
            {
                if (Slist[i].Id == id && Slist[i].Password == password )
                {
                    return 1;
                }

            }
            for (int i = 0; i < 1; i++)
            {
                if (Plist[i].Id == id && Plist[i].Password == password)
                {
                    return 2;
                }
            }
            return 0;      
        }
    }
}
