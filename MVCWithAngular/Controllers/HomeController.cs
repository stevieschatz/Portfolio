using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithAngular.Models;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace MVCWithAngular.Controllers
{
    public class HomeController : Controller
    {
      

        public ActionResult Index()
        {
            var model = new BeerIndexVM();

                
               model.Beers.ToList();
               
            

            return View(model);
        }

        
        public ActionResult IndexVM() 
        {
            var model = new BeerIndexVM();

            model.Beers.ToList();
    
            return Json(model, JsonRequestBehavior.AllowGet);
        
        }




        [HttpPost]
        public ActionResult Edit(BeerEditVM model)
        {

            //This thread we sleep for a small fraction of time to see the Ladda to take effect
            Thread.Sleep(2000);

            var model1 = new BeerIndexVM();

            var beer = new Beer()
            {
                //The ID I hard coded for testing purposes

                Id = 9568369+1,
                Name = model.Name,
                Colour = model.Colour,
                HasTried = model.HasTried



            };

            model1.Beers.Add(beer);
            
            return Json(beer, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Delete(int id) 
        {   
            var model = new BeerIndexVM();

            var existing = model.Beers.FirstOrDefault(x => x.Id == id);

            if(existing != null)
            {
                    model.Beers.Remove(existing);

               
            }

            return RedirectToAction("Index","Home");
        
        }


       

    }
}
