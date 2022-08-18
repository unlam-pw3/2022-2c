using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioPreguntasAI
    {
        private const string OPENAI_API_KEY = "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";
        private const string OPENAI_URL = "https://api.openai.com/v1/engines/text-davinci-002/completions";
        public static void EjecutarPreguntas()
        {
            Console.WriteLine("pregunta lo que quieras saber!");
            string pregunta = Console.ReadLine();
            do
            {
                string respuesta = PreguntarAI(pregunta, 150);
                Console.WriteLine(respuesta);
                Console.WriteLine();
                Console.WriteLine("pregunta otra cosa que quieras saber!");
                pregunta = Console.ReadLine();
            } while (!string.IsNullOrEmpty(pregunta.Trim()));
        }

        private static string PreguntarAI(string pregunta, int maxTokens)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("POST"), OPENAI_URL))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + OPENAI_API_KEY);

                    request.Content = new StringContent("{ " +
                            "\"prompt\": \"" + pregunta + "\", " +
                            "\"temperature\": 0.7, " +
                            "\"max_tokens\": " + maxTokens + ", " +
                            "\"top_p\": 1, " +
                            "\"frequency_penalty\": 0, " +
                            "\"presence_penalty\": 0" +
                            "}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = client.SendAsync(request).Result;
                    var json = response.Content.ReadAsStringAsync().Result;
                    dynamic dynObj = JsonConvert.DeserializeObject(json);
                    if (dynObj != null)
                    {
                        return dynObj.choices[0].text.ToString();
                    }
                }
                return string.Empty;
            }
        }
    }
}
