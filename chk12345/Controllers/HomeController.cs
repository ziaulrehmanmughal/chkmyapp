using chk12345.DBFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chk12345.Controllers
{
    public class HomeController : Controller
    {
        dbContext obj = new dbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(user bj)
        {
            if(ModelState.IsValid)
            {
                try {
                    obj.users.Add(bj);
                    obj.SaveChanges();
                }
                catch(Exception e)
                {
                    return View();
                }

            }
            TempData["added"] = true;
            return RedirectToAction("Index");
        }
        public ActionResult List()
        {
            return View(obj.users.ToList());
        }
    }
}