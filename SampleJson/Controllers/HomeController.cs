using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleJson.Models;

namespace SampleJson.Controllers
{
    public class HomeController : Controller
    {
        // GET: آخئث
        public ActionResult Index()
        {
            return View();
        }
        JsonSampleEntities db = new JsonSampleEntities();
        [HttpPost]
        public JsonResult GetList()
        {
            return Json(db.Test.ToList());
        }

        public JsonResult Add(Test test)
        {
            db.Test.Add(test);
            db.SaveChanges();
            return Json(db.Test.ToList());
        }
    }
}