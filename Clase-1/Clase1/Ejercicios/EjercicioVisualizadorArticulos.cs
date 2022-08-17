using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioVisualizadorArticulos
    {
        public static void VisualizarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();

            Articulo articulo1 = new Articulo();
            articulo1.SubTitulo = "El jugador se enfado luego de la sustitucion";
            articulo1.Titulo = "Escandalo con Inzaurralde!";
            articulos.Add(articulo1);

            for (int i = 0; i < 10; i++)
            {
                articulos.Add(new Articulo() { Titulo = $"Art {i}", SubTitulo = $"resumen {i}" });
            }

            Console.WriteLine("Articulos:");
            foreach (Articulo articulo in articulos)
            {
                Console.WriteLine($"Titulo: {articulo.Titulo}");
                Console.WriteLine($"SubTitulo: {articulo.SubTitulo}");
            }

            //Articulo articulo2 = new Articulo()
            //{
            //    Titulo = "",
            //    SubTitulo = "",
            //};
        }
    }
}
