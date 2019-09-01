using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI_Restaurant
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // -- AJOUTER --
            // -- Dans Package Nuguet installer Cors --
            // -- Install-Package Microsoft.AspNet.WebApi.Cors
            config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers: "*", methods:"*"));
        }
    }
}
