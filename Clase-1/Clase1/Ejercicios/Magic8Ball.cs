using System;

public class Magic8Ball
{
    private List<String> answers = new List<String>();
    private Random rand = new Random();
    private int randNumber;

    public Magic8Ball()
    {
        this.answers.Add("Es cierto.");
        this.answers.Add("Es decididamente así.");
        this.answers.Add("Sin lugar a dudas.");
        this.answers.Add("Sí, definitivamente.");
        this.answers.Add("Puedes confiar en ello.");
        this.answers.Add("Como yo lo veo, sí.");
        this.answers.Add("Lo más probable.");
        this.answers.Add("Perspectiva buena.");
        this.answers.Add("Sí.");
        this.answers.Add("Las señales apuntan a que sí.");
        this.answers.Add("Respuesta confusa, vuelve a intentarlo.");
        this.answers.Add("Vuelve a preguntar más tarde.");
        this.answers.Add("Mejor no decirte ahora.");
        this.answers.Add("No se puede predecir ahora.");
        this.answers.Add("Concéntrate y vuelve a preguntar.");
        this.answers.Add("No cuentes con ello.");
        this.answers.Add("Mi respuesta es no.");
        this.answers.Add("Mis fuentes dicen que no.");
        this.answers.Add("Las perspectivas no son muy buenas.");
        this.answers.Add("Muy dudoso.");

        this.randNumber = rand.Next(0, answers.Count());
    }

    public void playMagic8Ball(string question)
    {
        if (string.IsNullOrEmpty(question))
        {
            Console.WriteLine("Error en la pregunta.");
        }

        Console.WriteLine("Respuesta: {0}", answers.ElementAt(this.randNumber));
    }
}



