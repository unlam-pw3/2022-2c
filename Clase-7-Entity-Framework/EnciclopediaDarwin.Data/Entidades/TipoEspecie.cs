using System;
using System.Collections.Generic;

namespace EnciclopediaDarwin.Data.Entidades
{
    public partial class TipoEspecie
    {
        public TipoEspecie()
        {
            Especies = new HashSet<Especie>();
        }

        public int IdTipoEspecie { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Especie> Especies { get; set; }
    }
}
