using System.Web.Http;

namespace TrianglesApplication
{
    /// <summary>
    /// WebApi Application Global Root
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Application Start
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}