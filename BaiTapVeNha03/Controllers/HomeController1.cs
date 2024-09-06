using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha03.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MayTinh(double a, double b, string pheptinh)
        {
            return View();
        }
    }
}
