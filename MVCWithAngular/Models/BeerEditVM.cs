using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithAngular.Models
{
    public class BeerEditVM
    {
        

        public int? Id { get; set; }
        public string Name { get; set; }
        public String Colour { get; set; }
        public bool HasTried { get; set; }

    }
}