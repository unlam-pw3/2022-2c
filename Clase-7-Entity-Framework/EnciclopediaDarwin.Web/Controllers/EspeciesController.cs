using EnciclopediaDarwin.Logica;
using Microsoft.AspNetCore.Mvc;

namespace EnciclopediaDarwin.Web.Controllers
{
    public class EspeciesController : Controller
    {
        private IEspecieServicio _especieServicio;
        public EspeciesController(IEspecieServicio especieServicio)
        {
            _especieServicio = especieServicio;
        }
        public IActionResult Lista()
        {
            return View(_especieServicio.ObtenerTodos());
        }
    }
}
