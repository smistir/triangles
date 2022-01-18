using System.Web.Http;
using TrianglesApplication.Extensions;
using TrianglesApplication.Models;

namespace TrianglesApplication.Controllers
{
    /// <summary>
    /// WebApi Entry-Point for TriangleCoordinates Items
    /// </summary>
    [RoutePrefix("api/triangle-coordinates")]
    public class TriangleCoordinatesController : ApiController
    {
        /// <summary>
        /// Method to get a TriangleCoordinates from a TriangleLocation item
        /// </summary>
        /// <param name="triangleLocation"></param>
        /// <returns></returns>
        [Route(nameof(GetTriangleCoordinatesByTriangleLocation))]
        [HttpGet]
        public IHttpActionResult GetTriangleCoordinatesByTriangleLocation([FromBody] TriangleLocation triangleLocation)
        {
            if (!triangleLocation.IsValid())
            {
                return BadRequest("Input location is not valid and Triangle Coordinates could not be calculated");
            }

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            if (triangleCoordinates == null)
            {
                return BadRequest("There was a problem calculating the triangle coordinates");
            }

            return Ok(triangleCoordinates);
        }
    }
}
