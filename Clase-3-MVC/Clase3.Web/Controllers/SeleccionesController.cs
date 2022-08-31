using Clase3.Entidades;
using Clase3.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.Web.Controllers
{
    public class SeleccionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Todas()
        {
            SeleccionService seleccionService = new SeleccionService();
            List<Seleccion> todasSelecciones = seleccionService.ObtenerTodas();
            return View(todasSelecciones);
        }
    }
}
