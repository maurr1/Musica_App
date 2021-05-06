using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaAi.DomainModel.Entities
{
    public class DetalleSubgenero
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Duracion { get; set; }
        public string Imagen { get; set; }
        public string SpotifyApiUri { get; set; }
        public string Subgenero { get; set; }

        public DetalleSubgenero(string nombre, string artista, string duracion, string imagen, string spotify_api_uri, string subgenero)
        {
            
            Nombre = nombre;
            Artista = artista;
            Duracion = duracion;
            Imagen = imagen;
            SpotifyApiUri = spotify_api_uri;
            Subgenero = subgenero;
        }

    }
}
