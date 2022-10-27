using Clase5.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase5.Web.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View(PhoneNumber.TelefonoEjemplo());
        }
    }
}
