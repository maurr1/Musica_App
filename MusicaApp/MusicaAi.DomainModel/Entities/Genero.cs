using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaAi.DomainModel.Entities
{
   public class Genero
    {
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }

		public Genero(int id, string nombre, string descripcion)
		{
			Id = id;
			Nombre = nombre;
			Descripcion = descripcion;
		}
	}
}
