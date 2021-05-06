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
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/detalle")]
    public class DetalleController : ApiController
    {

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage getDetalleIdCancion(int id)
        {
            var detalle = DetallesRepository.ConsultarCancionesId(id);
            if (detalle == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            return Request.CreateResponse(HttpStatusCode.OK, detalle);
        }

    }
}
