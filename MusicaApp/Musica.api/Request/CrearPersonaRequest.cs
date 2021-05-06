using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musica.api.Request
{
    public class CrearPersonaRequest
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Administrador { get; set; }
        public bool Contribuidor { get; set; }
    }
}