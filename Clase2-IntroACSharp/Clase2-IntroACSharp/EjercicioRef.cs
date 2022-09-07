using System;
namespace Clase2_IntroACSharp
{
    public class EjercicioRef
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            //lo cambio necesito otro nombre
            CambiarNombre(ref nombre);

            Console.WriteLine("Nombre cambiado:");
            Console.WriteLine(nombre);
            Console.ReadLine();
        }

        private static void CambiarNombre(ref string nombre)
        {
            nombre = "Otro Nombre";
        }
    }
}

