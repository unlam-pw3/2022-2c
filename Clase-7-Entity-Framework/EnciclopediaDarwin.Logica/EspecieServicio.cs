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
    }
    public class EspecieServicio : IEspecieServicio
    {
        private _20222CEnciclopediaDarwinContext _context;
        public EspecieServicio(_20222CEnciclopediaDarwinContext context)
        {
            _context = context;
        }
        public void Insertar(Especie especie)
        {
            _context.Especies.Add(especie);
            _context.SaveChanges();
        }

        public List<Especie> ObtenerTodos()
        {
            return _context.Especies.ToList();
        }
    }
}
