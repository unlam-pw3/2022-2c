using System;
namespace Clase2_IntroACSharp
{
    public class EjercicioIfSwitch
    {
        enum Color
        {
            Amarillo = 1,
            Azul = 2,
            Rojo = 3,
        }

        public static void Ejecutar()
        {
            int colorElegidoInt1 = IngreseColor();
            Console.WriteLine();

            Color colorElegido1 = (Color)colorElegidoInt1;

            switch (colorElegido1)
            {
                case Color.Amarillo:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Elegiste el color Amarillo");
                    break;
                case Color.Azul:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Elegiste el color Azul");
                    break;
                case Color.Rojo:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Elegiste el color Rojo");
                    break;
                default:
                    Console.WriteLine("OPCION INCORRECTA");
                    return;
            }

            int colorElegidoInt2 = IngreseColor();
            Color colorElegido2 = (Color)colorElegidoInt2;

            if ((colorElegido1 == Color.Amarillo && colorElegido2 == Color.Azul) || (colorElegido1 == Color.Azul && colorElegido2 == Color.Amarillo))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El color resultante es Verde");
            }
            else if ((colorElegido1 == Color.Amarillo && colorElegido2 == Color.Rojo) || (colorElegido1 == Color.Rojo && colorElegido2 == Color.Amarillo))
            {
                Console.WriteLine("El color resultante es Naranja");
            }
            else if ((colorElegido1 == Color.Rojo && colorElegido2 == Color.Azul) || (colorElegido1 == Color.Azul && colorElegido2 == Color.Rojo))
            {
                Console.WriteLine("El color resultante es Violeta");
            }
            else if (colorElegido1 == colorElegido2)
            {
                Console.WriteLine("El color resultante es " + colorElegido1.ToString() + " -.-");
            }
        }

        private static int IngreseColor()
        {
            int colorElegidoInt1 = 0;

            do
            {
                Console.WriteLine("Elija un color:");
                Console.WriteLine("1. Amarillo");
                Console.WriteLine("2. Azul");
                Console.WriteLine("3. Rojo");
                string colorElegido1 = Console.ReadLine();
                int.TryParse(colorElegido1, out colorElegidoInt1);
            } while (colorElegidoInt1 < 1 || colorElegidoInt1 > 3);

            return colorElegidoInt1;
        }
    }
}

