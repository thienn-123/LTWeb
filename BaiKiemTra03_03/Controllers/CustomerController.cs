using BaiKiemTra03_03.Data;
using BaiKiemTra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra03_03.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customer = _context.Customer.ToList();
			ViewBag.Customer = customer;
            return View(customer);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customer.Add(customer);
                //Luu lại
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
		[HttpGet]

		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var customer = _context.Customer.Find(id);
			return View(customer);
		}
		[HttpPost]
		public IActionResult Edit(Customer customer)
		{
			if (ModelState.IsValid)
			{
				// thêm thông tin vào bảng theloai
				_context.Customer.Update(customer);
				//Luu lại
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public IActionResult Details(int? id)
		{
			if (id == null)
			{
				return NotFound(); // Kiểm tra xem id có hợp lệ hay không
			}

			var customer = _context.Customer
				.FirstOrDefault(c => c.Id == id); // Tìm khách hàng theo id

			if (customer == null)
			{
				return NotFound(); // Nếu không tìm thấy khách hàng, trả về NotFound
			}

			return View(customer); // Trả về View với model là đối tượng khách hàng
		}
	}
}
