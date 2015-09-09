using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCWithAngular.Models
{
    public class Beer
    {
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string Colour { get; set; }
        public bool HasTried { get; set; }


        public Beer(int? id, string name, string colour, bool hasTried) 
        {
            this.Id = id;
            this.Name = name;
            this.Colour = colour;
            this.HasTried = hasTried;


        }

    }
}
