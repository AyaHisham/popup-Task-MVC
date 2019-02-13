using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testmyjob.Controllers
{
    public class HomeController : Controller
    {
       // public testjEntities3 context = new testjEntities3();

        public ActionResult Index()
        {
            return View();
        }


        // you will receive the id instead of the object ,then you can get the object by query string if you needed
        public ActionResult CreateSession(string id)
        {
            // for test without database
            id = 1.ToString(); ;
            var isRegisteredStudent = 1;
            //var isRegisteredStudent = context.HomeViewModels.Where(m => m.Id == id).FirstOrDefault();


            if (isRegisteredStudent != null)
            {
                //Sign the student in.             
                return PartialView("_Success");
            }
            else
            {
                ModelState.Clear();
                // return View("Index");
                return PartialView("_Falid");
            }
        }
    }
}