using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Web.Http;
using System.Web.Http.Results;
using TrianglesApplication.Controllers;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplicationTest.ControllerTests
{
    /// <summary>
    /// Test class for the TriangleLocationController
    /// </summary>
    [TestClass]
    public class TriangleLocationControllerTests
    {
        /// <summary>
        /// Tests NULL input parameter
        /// </summary>
        [TestMethod]
        public void GetTriangleLocationByTriangleCoordinates_NullParameter()
        {
            TriangleLocationController controller = new TriangleLocationController();

            IHttpActionResult result = controller.GetTriangleLocationByTriangleCoordinates(null);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        }

        /// <summary>
        /// Tests scenario where the input coordinates are invalid at VertexOne
        /// </summary>
        [TestMethod]
        public void GetTriangleLocationByTriangleCoordinates_InvalidCoordinates()
        {
            TriangleLocationController controller = new TriangleLocationController();

            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 10, 0, 0, 10, 10);

            IHttpActionResult result = controller.GetTriangleLocationByTriangleCoordinates(triangleCoordinates);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(BadRequestErrorMessageResult));
        }

        /// <summary>
        /// Tests scenario where the input coordinates valid and returns Ok with converted triangle
        /// </summary>
        [TestMethod]
        public void GetTriangleLocationByTriangleCoordinates_Success()
        {
            TriangleLocationController controller = new TriangleLocationController();

            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 10, 0, 0, 10, 10);

            IHttpActionResult result = controller.GetTriangleLocationByTriangleCoordinates(triangleCoordinates);

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<TriangleLocation>));

            OkNegotiatedContentResult<TriangleLocation> okResult = result as OkNegotiatedContentResult<TriangleLocation>;

            Assert.IsNotNull(okResult);
            Assert.IsNotNull(okResult.Content);
            Assert.IsTrue(okResult.Content.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(okResult.Content.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }
    }
}
