using System;
using System.Linq;

namespace Clase2_IntroACSharp
{
    public class EjercicioFor
    {
        public EjercicioFor()
        {
        }

        public static void Ejecutar()
        {
            int cant = 100;

            for (int i = cant; i > 0; i--)
            {
                // Console.WriteLine($"Contador {i}");
            }

            string[] personas = { "Pablo", "Pedro", "Patricio", "Maria", "Juana", "Federico", "Daniela" };

            // for (int i = 1; i < personas.Length; i++)
            // {
            // string persona = personas[i];
            // Console.WriteLine(persona);
            // }

            // foreach (var persona in personas)
            // {
            //    Console.WriteLine(persona);
            // }

            Console.WriteLine("Personas (ASC):");

            foreach (var persona in personas.Where(p => p.StartsWith("P")).OrderBy(p => p))
            {
                Console.WriteLine(persona);
            }

            Console.WriteLine("Personas (DESC):");
            foreach (var persona in personas.OrderByDescending(p => p))
            {
                Console.WriteLine(persona);
            }
        }
    }
}

