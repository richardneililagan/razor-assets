using RazorAssets.Data;
using RazorAssets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorAssets.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(int count = 100)
        {
            // let's build a model for our view
            var elements = new List<Element>();
            var random = new Random();

            for (var i = 0; i < count; i++)
            {
                elements.Add(new Element(random));
            }            

            QuickStorage.Model = elements;

            return View(elements);
        }

    }
}
