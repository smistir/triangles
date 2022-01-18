using System.Web.Http;

namespace TrianglesApplication
{
    /// <summary>
    /// WebApi Configuraton Class
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers WebApi Routes
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
