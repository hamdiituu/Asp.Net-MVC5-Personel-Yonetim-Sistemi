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
            ViewBag.action = "yeni";
            ViewBag.button = "Ekle";

            return View();
        }


        [Route("departman/yeni")]
        [HttpPost]
        public ActionResult YeniDepartmanEkle(string Ad)
        {
            
            var departman = new Departman();
            departman.Ad = Ad;
            departman.Id = 0;
            db.Departman.Add(departman);
            db.SaveChanges();
            return RedirectToRoute("departman");


        }

        [Route("departman/guncelle/{id}")]
        public ActionResult DepartmanGuncelle(int id)
        {

            var model = db.Departman.Find(id);

            if (model == null)
            {
                ViewBag.departmanadi = "Hatalı Seçim Yaptınız.";
            }
            else
            {

                ViewBag.departmanadi = model.Ad;
                ViewBag.departmanId = model.Id;

            }
            ViewBag.action = "guncelle";
            ViewBag.button = "Güncelle";

            return View("YeniDepartmanEkle");
        }

        [Route("departman/guncelle")]
        [HttpPost]
        public ActionResult Guncelle(Departman model)
        {
            
            var departman = new Departman();


            var guncellenecekDepertman = db.Departman.Find(model.Id);
            if (guncellenecekDepertman == null)
            {
                return HttpNotFound();
            }

            guncellenecekDepertman.Ad = model.Ad;

            db.SaveChanges();

            return RedirectToRoute("departman");

        }

        [Route("departman/sil/{id}")]
        [HttpGet]
        public ActionResult Sil(int id)
        {

            var silinecekDep = db.Departman.Find(id);
            if(silinecekDep == null)
            {
                return HttpNotFound();
            }

            db.Departman.Remove(silinecekDep);
            db.SaveChanges();

            return RedirectToRoute("departman");

        }




    }
}