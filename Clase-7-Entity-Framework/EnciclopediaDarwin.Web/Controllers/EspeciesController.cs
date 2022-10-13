using EnciclopediaDarwin.Data.Entidades;
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

        public IActionResult Alta()
        {
            ViewBag.TipoEspecies = _especieServicio.ObtenerTipoEspecies();
            return View();
        }

        [HttpPost]
        public IActionResult Alta(Especie especie)
        {
            _especieServicio.Insertar(especie);
            return RedirectToAction("Lista");
        }

        public IActionResult Lista()
        {
            return View(_especieServicio.ObtenerTodos());
        }

        public IActionResult Editar(int id)
        {
            ViewBag.TipoEspecies = _especieServicio.ObtenerTipoEspecies();
            var especie = _especieServicio.ObtenerPorId(id);
            if (especie == null)
               return RedirectToAction("Lista");

            return View(especie);
        }

        [HttpPost]
        public IActionResult Editar(Especie especie)
        {
            var especieEnDb = _especieServicio.ObtenerPorId(especie.IdEspecie);
            if (especieEnDb != null)
            {
                _especieServicio.Actualizar(especie);
            }
            
            return RedirectToAction("Lista");
        }

        public IActionResult Eliminar(int id)
        {
            var especie = _especieServicio.ObtenerPorId(id);
            if (especie != null)
            {
                _especieServicio.Eliminar(especie);
            }
            return RedirectToAction("Lista");
        }
    }
}
