using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase6.Evaluacion.Entidades;

namespace Clase6.Evaluacion.Logica.Servicios
{

    public interface IAlquilerAutosServicio
    {
        void RegistrarAlquiler(AlquilerAuto alquilerAuto);
        List<AlquilerAuto> Listar();
    }

    public class AlquilerAutosServicio : IAlquilerAutosServicio
    {
        private static List<AlquilerAuto> Lista { get; set; } = new List<AlquilerAuto>();

        private int ObtenerMaxId()
        {
            if (Lista.Count == 0) 
                return 0;
            
            return Lista.Max(o => o.Id);
        }
        public void RegistrarAlquiler(AlquilerAuto alquilerAuto)
        {
            alquilerAuto.Id = ObtenerMaxId() + 1;

            Lista.Add(alquilerAuto);
        }
        public List<AlquilerAuto> Listar()
        {
            return Lista;
        }
    }
}
