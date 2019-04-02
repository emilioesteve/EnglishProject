using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }

        public Student( int id, string name, int age, string nationality )
        {

            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;

        }

    }
}