using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testTiny.Models;

namespace testTiny.Controllers
{
    public class TinyController : Controller
    {
        // GET: Tiny
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TinyModel model)
        {
            return View();
        }
    }
}