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

        [Route("departman/yeni")]
        [HttpGet]
        public ActionResult YeniDepartmanEkle()
        {
            return View();
        }


        [Route("departman/yeni")]
        [HttpPost]
        public ActionResult YeniDepartmanEkle(string departmanadi)
        {

            var departman = new Departman();
            departman.Ad = departmanadi;
            db.Departman.Add(departman);
            db.SaveChanges();
            return RedirectToRoute("");
               
        
        }



    }
}