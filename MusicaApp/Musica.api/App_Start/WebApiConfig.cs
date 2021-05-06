using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Musica.api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            // Configuración y servicios de API web
            //Toda la configuracion inicial, como app.js
            // Rutas de API web
            //Aqui se obtiene la configuracion para la configuracion de json
            //Convierte los obetos de c# a json
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            // este config dice que todo sera json. no xaml
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //Esta es la configuracion JSON:
            //No guarda referencias a otros objetos en el json
            settings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            //Esto regreesa tod sin identado, en una sol a linea
            settings.Formatting = Formatting.None;
            //Para ignorar los nulls en vez de que truene.
            settings.NullValueHandling = NullValueHandling.Ignore;
            //En c# todo tiene que ir en camel case por buenas practicas y esto lo convierte a eso
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Esto es cors pero es un coontrolador 
            config.EnableCors();

            //Se configuran las rutas de los recursos 
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
