// Resolución Ejercicio Magic-Ball 8
using System;
using System.Collections.Generic;

namespace Ejercicios
{
    public class EjercicioBolaOchoMagica
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

        private const string bola = @"
               _.a$$$$$a._
             ,$$$$$$$$$$$$$.
           ,$$$$$$$$$$$$$$$$$.
          d$$$$$$$$$$$$$$$$$$$b
         d$$$$$$$$~'-`~$$$$$$$$b
        ($$$$$$$p   _   q$$$$$$$)
        $$$$$$$$   (_)   $$$$$$$$
        $$$$$$$$   (_)   $$$$$$$$
        ($$$$$$$b       d$$$$$$$)
         q$$$$$$$$a._.a$$$$$$$$p
          q$$$$$$$$$$$$$$$$$$$p
           `$$$$$$$$$$$$$$$$$'
             `$$$$$$$$$$$$$'
               `~$$$$$$$~'
        ";

        private static Random random = new Random();

        public static void Bola8()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("        Bienvenido a Bola 8 Mágica");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(bola);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Haz una pregunta a la Bola 8 Mágica: ");
            Console.WriteLine("La sabiduría de la Bola sólo admite preguntas dicotómicas(si/no)");
            Console.WriteLine("------------------------------------------------------------------");

            do
            {
                Console.WriteLine();
                Console.Write("Pregunta: ");

                Console.ReadLine();

                string respuesta = respuestasEstandar[random.Next(0, respuestasEstandar.Count - 1)];
                Console.WriteLine("Bola 8 Mágica: " + respuesta);
                Console.Write("Realizar otra pregunta ([S]/N): ");

            } while (Console.ReadLine().ToLower() != "n");


        }
    }
}