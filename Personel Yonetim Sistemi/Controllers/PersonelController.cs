using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personel_Yonetim_Sistemi.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        [Route("personel")]
        public ActionResult Index()
        {
            @ViewBag.personel = "active";
            return View();
        }
    }
}