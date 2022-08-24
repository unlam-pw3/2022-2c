
using System;

List<string> respuestasPosibles = new List<string>
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

Console.WriteLine("**********************************************");
Console.WriteLine("*                                            *");
Console.WriteLine("*        Bienvenido a Bola 8 Mágica          *");
Console.WriteLine("*                                            *");
Console.WriteLine("**********************************************");

Console.WriteLine("*********************************************************");
Console.WriteLine("*                                                       *");
Console.WriteLine("* Realiza tu pregunta que pueda contestarse con si o no *");
Console.WriteLine("*                                                       *");
Console.WriteLine("*********************************************************");

do
{
    Console.WriteLine();
    Console.Write("Pregunta: ");

    Console.ReadLine();

    string respuestaFInal = respuestasPosibles.PickRandom();
    Console.WriteLine("Respuesta: " + respuestaFInal);
    Console.Write("Queres preguntar de nuevo? (S/N): ");

} while (Console.ReadLine().ToUpper() == "S");

Console.Write("GAME OVER");






public static class Extensions
{
    private static Random rnd = new Random();

    public static T PickRandom<T>(this IList<T> source)
    {
        int randIndex = rnd.Next(source.Count);
        return source[randIndex];
    }
}

