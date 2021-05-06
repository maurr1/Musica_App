using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Musica.OutputAdapter.Repositories;
namespace Musica.api.Controllers
{
    [RoutePrefix("api/canciones")]
    [EnableCors("*", "*", "*")]
    public class CancionesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage getCanciones()
        {
            try
            {
                var listacanciones = CancionesRepository.ConsultarCancion();
                return Request.CreateResponse(HttpStatusCode.OK, listacanciones);
            }
            catch (Exception e)
            {
                Console.WriteLine("aaaaa", e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage getCancionId(int id)
        {
            var cancion = CancionesRepository.ConsultarCancionesId(id);
            if (cancion == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            return Request.CreateResponse(HttpStatusCode.OK, cancion);
        }
    }
}
