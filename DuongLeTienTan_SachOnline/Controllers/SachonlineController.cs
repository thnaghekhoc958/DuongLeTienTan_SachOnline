using DuongLeTienTan_SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DuongLeTienTan_SachOnline.Controllers
{

	public class SachonlineController : Controller
    {
		// Add this line to declare and initialize the data context
		private DataBookOnline db = new DataBookOnline();

		// GET: Sachonline
		public ActionResult Index()
        {
			var sachMoi = db.SACHes.OrderByDescending(s => s.NgayCapNhat).Take(6).ToList();
			return View(sachMoi);
        }

        public ActionResult ChuDePartial()
        {
			var chuDe = db.CHUDEs.ToList();
			return PartialView(chuDe);
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
			var sachBanNhieu = db.SACHes.OrderByDescending(s => s.NgayCapNhat).Take(6).ToList();
			return PartialView(sachBanNhieu);
		}
        public ActionResult FooterPartial()
        {
            return PartialView();
        }

		public ActionResult SachTheoNhaXuatBanPartial(int id)
		{
			var lstSach = db.SACHes.Where(s => s.MaNXB == id).ToList();
			return View(lstSach);
		}

		// Chi Tiết Sách Partial
		public ActionResult ChiTietSachPartial(int id)
		{
			var sach = db.SACHes.SingleOrDefault(s => s.MaSach == id);
			if (sach == null) return HttpNotFound();
			return View(sach);
		}



		//public ActionResult SachTheoChuDe(int id)
		//{
		//	var lstSach = db.SACHes.Where(s => s.MaCD == id).ToList();
		//	return View(lstSach);
		//}



	}
}