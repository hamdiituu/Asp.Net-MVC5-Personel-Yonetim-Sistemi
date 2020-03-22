﻿using Personel_Yonetim_Sistemi.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity

namespace Personel_Yonetim_Sistemi.Controllers
{
    public class PersonelController : Controller
    {
        PersonelYonetimSistemiEntities db = new PersonelYonetimSistemiEntities();
        // GET: Personel
        [Route("personel")]
        public ActionResult Index()
        {
            @ViewBag.personel = "active";

            var model = db.Personel.Include(x=>x.Departman).ToList();

            return View(model);
        }
    }
}