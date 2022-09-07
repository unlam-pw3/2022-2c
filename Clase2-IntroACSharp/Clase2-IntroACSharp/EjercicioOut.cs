using System;
namespace Clase2_IntroACSharp
{
    public class EjercicioOut
    {
        public EjercicioOut()
        {
        }

        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            string resultadoU;
            string resultadoL;

            ConvertirEnMayusculas(nombre, out resultadoL, out resultadoU);

            // ConvertirEnMayusculasSinOut(nombre);

            Console.WriteLine("En mayusculas:");
            Console.WriteLine(resultadoU);
            Console.WriteLine("En minusculas:");
            Console.WriteLine(resultadoL);
            Console.ReadLine();
        }

        private static bool ConvertirEnMayusculas(string nombre, out string resultadoLower, out string resultadoUpper)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                resultadoUpper = nombre.ToUpper();
                resultadoLower = nombre.ToLower();
                return true;
            }
            else
            {
                resultadoUpper = "Nombre vacío";
                resultadoLower = "Nombre vacío";
                return false;
            }
        }

        private static string ConvertirEnMayusculasSinOut(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                return nombre.ToLower();
            }
            else
            {
                return "Nombre vacio";
            }
        }
    }
}

