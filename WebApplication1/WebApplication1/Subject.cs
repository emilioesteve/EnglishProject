using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website
{
    public class Subject
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public double Credits { get; set; }

        public Subject( int id, string title, double credits )
        {

            this.Id = id;
            this.Title = title;
            this.Credits = credits;

        }

    }
}