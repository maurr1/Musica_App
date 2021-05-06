using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaAi.DomainModel.Entities
{
   public class Persona
    {
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Contraseña { get; set; }
		public string Administrador { get; set; }
		public bool Contribuidor { get; set; }

		public Persona(int id, string nombre, string contraseña, string administrador, bool contribuidor)
		{
			Id = id;
			Nombre = nombre;
			Contraseña = contraseña;
			Administrador = administrador;
			Contribuidor = contribuidor;
		}
	}
}

