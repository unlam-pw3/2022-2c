using System;
using System.Collections.Generic;

namespace Ejercicios
{
    public class BolaOcho
    {
        private static List<string> respuestasEstandar = new List<string>
        {
            // Respuestas afirmativas
            "Es cierto.",
            "Es decididamente así.",
            "Sin lugar a dudas.",
            "Sí, definitivamente.",
            "Puedes confiar en ello.",
            "Como yo lo veo, sí.",
            "Lo más probable.",
            "Perspectiva buena.",
            "Sí.",
            "Las señales apuntan a que sí.",
            // Respuestas no comprometidas
            "Respuesta confusa, vuelve a intentarlo.",
            "Vuelve a preguntar más tarde.",
            "Mejor no decirte ahora.",
            "No se puede predecir ahora.",
            "Concéntrate y vuelve a preguntar.",
            // Respuestas negativas
            "No cuentes con ello.",
            "Mi respuesta es no.",
            "Mis fuentes dicen que no.",
            "Las perspectivas no son muy buenas.",
            "Muy dudoso."
        };

                private static Random random = new Random();

        public static void iniciar()
        {
            Console.WriteLine("        Bienvenido a Bola 8 Mágica");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Haz una pregunta a la Bola 8 Mágica (recuerda que la pregunta debe ser de respuesta si/no): ");
            Console.WriteLine("------------------------------------------------------------------");

            do
            {
                Console.WriteLine();
                Console.Write("Pregunta: ");

                Console.ReadLine();

                string respuesta = respuestasEstandar[random.Next(0, 19)];
                Console.WriteLine("Bola 8 Mágica: " + respuesta);
                Console.Write("Realizar otra pregunta ([s]/n): ");

            } while (Console.ReadLine().ToLower() != "n");
        }
    }
}