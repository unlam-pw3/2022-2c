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
        public List<Seleccion> ObtenerClasificadas();
        public List<Seleccion> ObtenerClasificadasAlf();
        public void Agregar(Seleccion seleccion);
    }
    public class SeleccionService : ISeleccionService
    {
        private static List<Seleccion> Selecciones { get; set; } = new List<Seleccion>() 
        {
            new Seleccion() { Pais = "Argentina", Clasificada = true,
                             Continente = "America",Federacion = "AFA"},
            new Seleccion() { Pais = "Brasil", Clasificada = true,
                             Continente = "America",Federacion = "CBF"},
            new Seleccion() { Pais = "Italia", Clasificada = false,
                             Continente = "Europa",Federacion = "FIGC"},
            new Seleccion() { Pais = "Alemania", Clasificada = true,
                             Continente = "Europa",Federacion = "DFB"},
        };

        public List<Seleccion> ObtenerTodas()
        {
            return Selecciones;
        }

        public List<Seleccion> ObtenerClasificadas()
        {
            return Selecciones.Where(o => o.Clasificada).ToList();
        }

        public List<Seleccion> ObtenerClasificadasAlf()
        {
            List<Seleccion> clasificadas = Selecciones.Where(o => o.Clasificada).ToList();
            return clasificadas.OrderBy(o => o.Pais).ToList();
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
