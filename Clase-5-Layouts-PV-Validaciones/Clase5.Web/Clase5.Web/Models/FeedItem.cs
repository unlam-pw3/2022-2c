namespace Clase5.Web.Models
{
    public class FeedItem
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string ImagenUrl { get; set; }
        public string PerfilUrl { get; set; }
        public string HoraComentario { get; set; }
        public string Comentario { get; set; }

        public static List<FeedItem> ListaEjemplo()
        {
            List<FeedItem> listaEjemplo = new List<FeedItem>();
            for (int i = 0; i < 20; i++)
            {
                FeedItem itemNuevo = new FeedItem()
                {
                    Id = i,
                    Usuario = $"Usuario {i.ToString()}",
                    Comentario = "Comentario",
                    HoraComentario = $"{i} Min",
                    ImagenUrl = $"https://cdn-icons-png.flaticon.com/512/147/147144.png",
                    PerfilUrl = $"https://www.google.com/search?q=usuario+{i}"
                };
                listaEjemplo.Add(itemNuevo);
            }

            return listaEjemplo;
        }
    }
}
