﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuongLeTienTan_SachOnline.Controllers
{
    public class SachonlineController : Controller
    {
        // GET: Sachonline
        public ActionResult Index()
        {

            return View();
        }
		public ActionResult ChudePartial()
		{

			return View();
		}

		public ActionResult NavPartial()
		{
			return PartialView();
		}

		public ActionResult SliderPartial()
		{
			return PartialView();
		}
		public ActionResult NhaXuatBanPartial()
		{
			return PartialView();
		}
		public ActionResult SachBanNhieuPartial()
		{
			return PartialView();
		}
		public ActionResult FooterPartial()
		{
			return PartialView();
		}


	}
}