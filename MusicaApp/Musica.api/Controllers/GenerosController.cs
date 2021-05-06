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
    [RoutePrefix("api/generos")]
    public class GenerosController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObtenerGeneros()
        {
            try
            {
                var listaGeneros = GenerosRepository.ConsultarGeneros();


                return Request.CreateResponse(HttpStatusCode.OK, listaGeneros);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Exception has been caught:{e.Message}");
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage ObtenerGeneroPorId(int id)
        {
            try
            {
                var genero = GenerosRepository.ConsultarGeneroId(id);

                if (genero == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, genero);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Exception has been caught:{e.Message}");
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }

        }

    }
}
