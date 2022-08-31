using Clase3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Logica
{
    public class SeleccionService
    {
        private static List<Seleccion> Selecciones { get; set; } = new List<Seleccion>() 
        {
            new Seleccion() { Pais = "Argentina", Clasificada = true, Continente = "America"},
            new Seleccion() { Pais = "Brasil", Clasificada = true, Continente = "America"},
            new Seleccion() { Pais = "Italia", Clasificada = false, Continente = "Europa"},
        };

        public List<Seleccion> ObtenerTodas()
        {
            return Selecciones;
        }

        public List<Seleccion> ObtenerClasificados()
        {
            return Selecciones.Where(o => o.Clasificada).ToList();
        }
    }
}
