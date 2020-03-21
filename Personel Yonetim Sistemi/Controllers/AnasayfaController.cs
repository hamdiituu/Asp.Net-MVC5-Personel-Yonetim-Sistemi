using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personel_Yonetim_Sistemi.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}