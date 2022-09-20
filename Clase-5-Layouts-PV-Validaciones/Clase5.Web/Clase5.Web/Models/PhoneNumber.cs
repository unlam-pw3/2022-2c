namespace Clase5.Web.Models
{
    public class PhoneNumber
    {
        public int CodigoPais { get; set; }

        public int CodigoArea { get; set; }

        public int Numero { get; set; }

        public static PhoneNumber TelefonoEjemplo()
        {
            return new PhoneNumber
            {
                CodigoPais = 54,
                CodigoArea = 11,
                Numero = 11111111
            };
        }

    }

}