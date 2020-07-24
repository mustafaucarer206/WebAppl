using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPP.Models.Sınıflar;

namespace WebAPP.Controllers
{
    public class AboutController : Controller
    {
        // GET: Abaut
        Context snf = new Context();
        
        public ActionResult Index()
        {
            var degerler = snf.Hakkimisdas.ToList();
            return View(degerler);
        }
    }
}