using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Entidades
{
    public class Seleccion
    {
        public enum Continentes { America, Europa, Asia, Africa, Oceania, Antartida }
        public enum Confederaciones { AFC, CAF, CONCACAF, CONMEBOL, OFC, UEFA, }
        public string Pais { get; set; } = string.Empty;
        public bool Clasificada { get; set; }
        public Continentes Continente { get; set; }
        public Confederaciones Confederacion { get; set; }
    }

}
