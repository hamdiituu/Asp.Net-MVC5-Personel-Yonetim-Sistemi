﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personel_Yonetim_Sistemi.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman

        [Route("departman")]
        public ActionResult Index()
        {
            @ViewBag.departman = "active";
            return View();
        }
    }
}