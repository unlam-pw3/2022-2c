using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioManejoDeTexto
    {
        public static void EjemploMayusculas()
        {
            Console.WriteLine("Ingrese texto:");
            string linea1 = Console.ReadLine();

            Console.WriteLine("En MAYUSCULA:");
            Console.WriteLine(ConvertirAMayuscula(linea1));

            Console.WriteLine("En minuscula:");
            Console.WriteLine(ConvertirAMinuscula(linea1));
        }

        private static string ConvertirAMayuscula(string texto)
        {
            return texto.ToUpper();
        }

        private static string ConvertirAMinuscula(string texto)
        {
            return texto.ToLower();
        }
    }
}
