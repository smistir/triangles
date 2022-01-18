using System.Web.Http;
using TrianglesApplication.Extensions;
using TrianglesApplication.Models;

namespace TrianglesApplication.Controllers
{
    /// <summary>
    /// WebApi Entry-Point for TriangleLocation Items
    /// </summary>
    [RoutePrefix("api/triangle-location")]
    public class TriangleLocationController : ApiController
    {
        /// <summary>
        /// Method to get a TriangleLocation from a TriangleCoordinate item
        /// </summary>
        /// <param name="triangleCoordinates"></param>
        /// <returns></returns>
        [Route(nameof(GetTriangleLocationByTriangleCoordinates))]
        [HttpGet]
        public IHttpActionResult GetTriangleLocationByTriangleCoordinates([FromBody] TriangleCoordinates triangleCoordinates)
        {
            if (!triangleCoordinates.IsValid())
            {
                return BadRequest("Input coordinates are invalid and the Triangle Location cannot be calculated");
            }

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            if (triangleLocation == null)
            {
                return BadRequest("There was a problem calculating the triangle location");
            }

            return Ok(triangleLocation);
        }
    }
}
