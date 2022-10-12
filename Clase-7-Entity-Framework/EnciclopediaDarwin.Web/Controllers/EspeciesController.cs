using Microsoft.AspNetCore.Mvc;

namespace EnciclopediaDarwin.Web.Controllers
{
    public class EspeciesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
