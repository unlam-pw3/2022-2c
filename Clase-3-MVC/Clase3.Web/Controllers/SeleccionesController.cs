using Clase3.Entidades;
using Clase3.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.Web.Controllers
{
    public class SeleccionesController : Controller
    {
        private ISeleccionService _seleccionService;

        public SeleccionesController(ISeleccionService seleccionService)
        {
            _seleccionService = seleccionService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Todas()
        {
            List<Seleccion> todasSelecciones = _seleccionService.ObtenerTodas();
            return View(todasSelecciones);
        }
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Seleccion seleccion)
        {
            _seleccionService.Agregar(seleccion);
            return Redirect("/selecciones/todas");
        }
    }
}
