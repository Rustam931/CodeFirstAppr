using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstAppr.Models;
using PagedList.Mvc;
using PagedList;

namespace CodeFirstAppr.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();

        // GET: Home
        public ActionResult Index(int? i)
        {
            var data = db.Products.ToList().ToPagedList(i ?? 1, 9);
            return View(data);
        }
    }
}