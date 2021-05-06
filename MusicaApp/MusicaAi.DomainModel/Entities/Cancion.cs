using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaAi.DomainModel.Entities
{
   public  class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Duracion { get; set; }
        public string Imagen { get; set; }
        public string SpotifyApiUri { get; set; }


        public Cancion(int id, string nombre, string artista, string duracion, string imagen, string spotify_api_uri) {
            Id = id;
            Nombre = nombre;
            Artista = artista;
            Duracion = duracion;
            Imagen = imagen;
            SpotifyApiUri= spotify_api_uri;
        }


    }
}
