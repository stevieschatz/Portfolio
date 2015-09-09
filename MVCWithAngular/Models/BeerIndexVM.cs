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
            //Hard coded this for testing
            //You will never be able to delete these two beer because they will get added again everytime

            Beer beer = new Beer(1234567, "Heiniken", "Amber", false);
            Beer beer1 = new Beer(7654321, "Abel", "Victory", true);

            Beers = new List<Beer>();
            
            Beers.Add(beer);
            Beers.Add(beer1);
            
        }


    }

   
}