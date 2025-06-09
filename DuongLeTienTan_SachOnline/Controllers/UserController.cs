using DuongLeTienTan_SachOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuongLeTienTan_SachOnline.Controllers
{
    public class UserController : Controller
    {
		// GET: User
		private DataBookOnline db = new DataBookOnline();

		[HttpGet]
		public ActionResult DangKyPartial()
		{
			return View();
		}

		[HttpPost]
		public ActionResult DangKy(FormCollection f)
		{
			//string tenDN = f["TenDN"];
		

			//if (db.NGUOIDUNGs.SingleOrDefault(u => u.tenDN == tenDN) != null)
			//{
			//	ViewBag.ThongBao = "Tên đăng nhập đã tồn tại!";
			//	return View();
			//}

			NGUOIDUNG nd = new NGUOIDUNG
			{
				HoTen = f["HoTen"],
				//TenDN = f["TenDN"],
				MatKhau = f["MatKhau"],
				Email = f["Email"],
				DienThoai = f["DienThoai"],
				NgayDangKy = DateTime.Parse(f["NgayDangKy"]),
				DiaChi = f["DiaChi"]
			};

			db.NGUOIDUNGs.Add(nd);
			db.SaveChanges();
			ViewBag.ThongBao = "Đăng ký thành công!";
			return View();
		}


	}
}