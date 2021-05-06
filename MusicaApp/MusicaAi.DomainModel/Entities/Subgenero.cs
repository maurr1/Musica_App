using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaAi.DomainModel.Entities
{
   public class Subgenero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Genero { get; set; }

        public Subgenero(int id, string nombre, string descripcion, int genero) {

            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Genero = genero;
        }

    }
}
