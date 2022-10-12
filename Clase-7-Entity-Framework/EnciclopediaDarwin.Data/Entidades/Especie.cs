using System;
using System.Collections.Generic;

namespace EnciclopediaDarwin.Data.Entidades
{
    public partial class Especie
    {
        public int IdEspecie { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? PesoPromedioKg { get; set; }
        public int? EdadPromedioAños { get; set; }
        public int IdTipoEspecie { get; set; }

        public virtual TipoEspecie IdTipoEspecieNavigation { get; set; } = null!;
    }
}
