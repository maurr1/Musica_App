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
    [RoutePrefix("api/subgeneros")]
    public class SubgeneroController : ApiController
    {
        /*
         [HttpGet]
        public HttpResponseMessage ObtenerSubgeneros()
        {
            try
            {
                var listaSubgeneros = SubgenerosRepository.ConsultarSubgeneros();              
                return Request.CreateResponse(HttpStatusCode.OK, listaSubgeneros);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Exception has been caught:{e.Message}");
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage ObtenerSubgeneroPorId(int id)
        {
            try
            {
                var subgenero = SubgenerosRepository.ConsultarSubgeneroPorId(id);

                if (subgenero == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, subgenero);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Exception has been caught:{e.Message}");
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }
         */

    }
}
