using BaiKiemTra02.Data;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        private string? lophoc;

        public LopHocController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var lophoc = _db.LopHoc.ToList();
            ViewBag.Lophoc = lophoc;
            return View();
        }

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(LopHoc lophoc)
		{
			if (ModelState.IsValid)
			{
				//Them thong tin vao bang theloai
				_db.LopHoc.Add(lophoc);
				//Luu lai
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(lophoc);
		}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lophoc = _db.LopHoc.Find(id);
            return View(lophoc);
        }

        [HttpPost]
        public IActionResult Edit(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.LopHoc.Update(lophoc);
                // Lưu lại
                _db.SaveChanges();
                // Chuyển trang về index
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lopHoc = _db.LopHoc.Find(id);
            return View(lopHoc);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var lopHoc = _db.LopHoc.Find(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            _db.LopHoc.Remove(lopHoc);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lopHoc = _db.LopHoc.Find(id);
            return View(lophoc);
        }

    }
}
