using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website
{
    public class Professor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Professor(int id, string name, string password )
        {

            this.Id = id;
            this.Name = name;
            this.Password = password;

        }

        public Professor()
        {
            this.Name = "Charles";
        }

    }
}