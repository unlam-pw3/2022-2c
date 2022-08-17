
public partial class Program
{
    public static void Main()
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


        //EjemploMayusculas();
        Console.ReadLine();
    }

    public static void EjemploMayusculas()
    {
        Console.WriteLine("Ingrese texto:");
        string linea1 = Console.ReadLine();

        Console.WriteLine("En MAYUSCULA:");
        Console.WriteLine(ConvertirAMayuscula(linea1));

        Console.WriteLine("En minuscula:");
        Console.WriteLine(ConvertirAMinuscula(linea1));
    }
    public static string ConvertirAMayuscula(string texto)
    {
        return texto.ToUpper();
    }

    public static string ConvertirAMinuscula(string texto)
    {
        return texto.ToLower();
    }
}

class Articulo
{
    public string Titulo{ get; set; }
    public string SubTitulo { get; set; }

}
