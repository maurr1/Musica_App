using Musica.api.Request;
using Musica.OutputAdapter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Musica.api.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/personas")]
    public class PersonasController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage getPersonas()
        {
            try
            {
                var listapersonas = PersonasRepository.ConsultarPersonas();
                return Request.CreateResponse(HttpStatusCode.OK, listapersonas);
            }
            catch (Exception e)
            {
                Console.WriteLine("aaaaa", e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage getAlumnoId(int id)
        {
            var persona = PersonasRepository.ConsultarPersonaId(id);
            if (persona == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            return Request.CreateResponse(HttpStatusCode.OK, persona);
        }

        [HttpPost]
        public HttpResponseMessage CrearPersona([FromBody] CrearPersonaRequest request)
        {
            var persona = PersonasRepository.InsertarPersona(request.Nombre, request.Contraseña, request.Administrador, request.Contribuidor);
            return Request.CreateResponse(HttpStatusCode.OK, persona);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage EliminarAlumno(int id)
        {
            PersonasRepository.EliminarPersona(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
