using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnciclopediaDarwin.Data.Entidades;

namespace EnciclopediaDarwin.Logica
{
    public interface IEspecieServicio
    {
        List<Especie> ObtenerTodos();
        void Insertar(Especie especie);

        List<TipoEspecie> ObtenerTipoEspecies();
        Especie ObtenerPorId(int id);
        void Eliminar(Especie especie);
    }
    public class EspecieServicio : IEspecieServicio
    {
        private _20222CEnciclopediaDarwinContext _context;
        public EspecieServicio(_20222CEnciclopediaDarwinContext context)
        {
            _context = context;
        }

        public void Eliminar(Especie especie)
        {
            _context.Especies.Remove(especie);
            _context.SaveChanges();
        }

        public void Insertar(Especie especie)
        {
            _context.Especies.Add(especie);
            _context.SaveChanges();
        }

        public Especie ObtenerPorId(int id)
        {
            return _context.Especies.Find(id);
        }

        public List<TipoEspecie> ObtenerTipoEspecies()
        {
            return _context.TipoEspecies.OrderBy(te => te.Nombre).ToList();
        }

        public List<Especie> ObtenerTodos()
        {
            return _context.Especies.ToList();
        }

    }
}
