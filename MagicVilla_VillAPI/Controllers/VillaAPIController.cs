using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    public class VillaAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
