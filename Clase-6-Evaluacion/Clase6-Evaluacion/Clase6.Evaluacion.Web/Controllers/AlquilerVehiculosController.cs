using Clase6.Evaluacion.Entidades;
using Clase6.Evaluacion.Logica.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.Evaluacion.Web.Controllers;

public class AlquilerVehiculosController : Controller
{
    public IAlquilerAutosServicio _alquilerAutoServicio { get; set; }
    public AlquilerVehiculosController(IAlquilerAutosServicio alquilerAutoServicio)
    {
        _alquilerAutoServicio = alquilerAutoServicio;
    }

    [HttpGet]
    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(AlquilerAuto alquilerAuto)
    {
        if (!ModelState.IsValid)
            return View(alquilerAuto);
        
        _alquilerAutoServicio.RegistrarAlquiler(alquilerAuto);
        return Redirect("/AlquilerVehiculos/Resultados");
    }

    [HttpGet]
    public IActionResult Resultados()
    {
        return View(_alquilerAutoServicio.Listar());
    }
}
