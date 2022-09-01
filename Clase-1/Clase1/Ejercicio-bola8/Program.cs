// See https://aka.ms/new-console-template for more information

public partial class Program
{
    public static void Main()
    {
        Console.WriteLine("Hagale una pregunta a la IA");
        Console.WriteLine("Ingrese una pregunta de SI/NO");
        Console.ReadLine();

        Random random = new Random();
        //0 afirmativo  1 dudosa   2negativa
        int TIpoRespuesta = random.Next(0, 3);
        int posicionPregunta = random.Next(0, 3);


        List<string> RespAfirmativas = new List<string>();
        List<string> RespNegativas = new List<string>();
        List<string> RespDudosas = new List<string>();

        RespAfirmativas.Add("Si");
        RespAfirmativas.Add("Si, te lo aseguro compañero");
        RespAfirmativas.Add("Si, totalmente bro");

        RespDudosas.Add("Puede que si puede que no");
        RespDudosas.Add("Yyyy nose mostro vo fijate");
        RespDudosas.Add("La respuesta esta en tu corazon");

        RespNegativas.Add("No flaco deja de joder");
        RespNegativas.Add("NO.");
        RespNegativas.Add("No, siguiente pregunta");

        if (TIpoRespuesta == 0)
        {
            Console.WriteLine(RespAfirmativas[posicionPregunta]);
        }

        if (TIpoRespuesta == 1)
        {
            Console.WriteLine(RespDudosas[posicionPregunta]);
        }

        if (TIpoRespuesta == 2)
        {
            Console.WriteLine(RespNegativas[posicionPregunta]);
        }
    }

}