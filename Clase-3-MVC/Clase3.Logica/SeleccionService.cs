using Clase3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Logica
{
    public interface ISeleccionService
    {
        public List<Seleccion> ObtenerTodas();
        public List<Seleccion> ObtenerClasificados();
        public List<Seleccion> ObtenerOrdenadasAlfabeticamenteClasificadas();
        public void Agregar(Seleccion seleccion);
    }
    public class SeleccionService : ISeleccionService
    {
        private static List<Seleccion> Selecciones { get; set; } = new List<Seleccion>() 
        {
            new Seleccion() { Pais = "Argentina", Clasificada = true, Continente = "America", Confederacion = "AFA"},
            new Seleccion() { Pais = "Brasil", Clasificada = true, Continente = "America", Confederacion = "AFA"},
            new Seleccion() { Pais = "Italia", Clasificada = false, Continente = "Europa", Confederacion = "FIGC"},
        };

        public List<Seleccion> ObtenerTodas()
        {
            return Selecciones;
        }

        public List<Seleccion> ObtenerClasificados()
        {
            return Selecciones.Where(o => o.Clasificada).ToList();
        }

        public List<Seleccion> ObtenerOrdenadasAlfabeticamenteClasificadas()
        {
            return Selecciones.Where(o => o.Clasificada).OrderBy(o => o.Pais).ToList();
        }

        private bool Existe(Seleccion seleccion)
        {
            return Selecciones.Any(s => string.Equals(s.Pais, seleccion.Pais, StringComparison.OrdinalIgnoreCase));
        }

        public void Agregar(Seleccion seleccion)
        {
            if (Existe(seleccion))
            {
                throw new SeleccionYaExistenteException();
            }
            Selecciones.Add(seleccion);
        }
    }
}
