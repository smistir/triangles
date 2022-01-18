using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrianglesApplication.Controllers;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;
using System.Web.Http;
using System.Web.Http.Results;

namespace TrianglesApplicationTest.ControllerTests
{
    /// <summary>
    /// Test class for the TriangleCoordinatesController
    /// </summary>
    [TestClass]
    public class TriangleCoordinatesControllerTests
    {
        /// <summary>
        /// Tests NULL input parameter
        /// </summary>
        [TestMethod]
        public void GetTriangleCoordinatesByTriangleLocation_NullParameter()
        {
            TriangleCoordinatesController controller = new TriangleCoordinatesController();

            IHttpActionResult result = controller.GetTriangleCoordinatesByTriangleLocation(null);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        }

        /// <summary>
        /// Tests scenario where input parameter is not null but not valid
        /// </summary>
        [TestMethod]
        public void GetTriangleCoordinatesByTriangleLocation_InvalidTriangleLocation()
        {
            TriangleCoordinatesController controller = new TriangleCoordinatesController();

            TriangleLocation triangleLocation = new TriangleLocation(((TriangleLocationRow)(-1)), ((TriangleLocationColumn)(-1)));

            IHttpActionResult result = controller.GetTriangleCoordinatesByTriangleLocation(triangleLocation);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is valid and returns Ok with converted triangle
        /// </summary>
        [TestMethod]
        public void GetTriangleCoordinatesByTriangleLocation_Success()
        {
            TriangleCoordinatesController controller = new TriangleCoordinatesController();

            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.One);

            IHttpActionResult result = controller.GetTriangleCoordinatesByTriangleLocation(triangleLocation);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<TriangleCoordinates>));

            OkNegotiatedContentResult<TriangleCoordinates> okResult = result as OkNegotiatedContentResult<TriangleCoordinates>;

            Assert.IsNotNull(okResult);
            Assert.IsNotNull(okResult.Content);
            Assert.IsTrue(okResult.Content.V1X == 0, "expected 0 but got " + okResult.Content.V1X + " for V1X");
            Assert.IsTrue(okResult.Content.V1Y == 10, "expected 10 but got " + okResult.Content.V1Y + " for V1Y");
            Assert.IsTrue(okResult.Content.V2X == 0, "expected 0 but got " + okResult.Content.V2X + " for V2X");
            Assert.IsTrue(okResult.Content.V2Y == 0, "expected 0 but got " + okResult.Content.V2Y + " for V2Y ");
            Assert.IsTrue(okResult.Content.V3X == 10, "expected 10 but got " + okResult.Content.V3X + " for V3X");
            Assert.IsTrue(okResult.Content.V3Y == 10, "expected 10 but got " + okResult.Content.V3Y + " for V3Y");
        }
    }
}
