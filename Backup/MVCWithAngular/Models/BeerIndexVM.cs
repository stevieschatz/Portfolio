using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithAngular.Models
{
    public class BeerIndexVM
    {
        public List<Beer> Beers { get; set; }

        public BeerIndexVM()
        {
            Beer beer = new Beer(1234567, "Heiniken", "Amber", false);
            Beer beer1 = new Beer(7654321, "Abel", "Victory", true);

            Beers = new List<Beer>();
            
            Beers.Add(beer);
            Beers.Add(beer1);
            
        }


    }
}