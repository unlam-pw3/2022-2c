using Clase6.Evaluacion.Entidades;
using Clase6.Evaluacion.Logica.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.Evaluacion.Web.Controllers;
public class InicioController : Controller
{
    public IActionResult Bienvenido()
    {
        return View();
    }
}
