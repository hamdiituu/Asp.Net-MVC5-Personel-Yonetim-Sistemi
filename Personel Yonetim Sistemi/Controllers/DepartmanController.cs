using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Personel_Yonetim_Sistemi.Models.EntityFramework;

namespace Personel_Yonetim_Sistemi.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman

        PersonelYonetimSistemiEntities db = new PersonelYonetimSistemiEntities();

        [Route("departman")]
        public ActionResult Index()
        {
            var model = db.Departman.ToList();
            @ViewBag.departman = "active";
            return View(model);
        }
    }
}