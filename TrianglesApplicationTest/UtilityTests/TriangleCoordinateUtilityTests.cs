using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglesApplication.Models.Enums;
using TrianglesApplication.Utilities;

namespace TrianglesApplicationTest.UtilityTests
{
    [TestClass]
    public class TriangleCoordinateUtilityTest
    {
        /// <summary>
        /// Tests scenario where input is greater than the bounds of the upper limit.  Should return Row-F
        /// </summary>
        [TestMethod]
        public void GetAdjustedTriangleLocationRow_GreaterThan_F()
        {
            TriangleLocationRow triangleLocationRow = TriangleCoordinateUtility.GetAdjustedTriangleLocationRow((TriangleLocationRow)99);

            Assert.IsTrue(triangleLocationRow == TriangleLocationRow.F, "expected triangleLocationRow to be F");
        }

        /// <summary>
        /// Tests scenario where the input is less then the bounds of the lower limit.  Should return Row-A
        /// </summary>
        [TestMethod]
        public void GetAdjustedTriangleLocationRow_LessThan_A()
        {
            TriangleLocationRow triangleLocationRow = TriangleCoordinateUtility.GetAdjustedTriangleLocationRow((TriangleLocationRow)(-1));

            Assert.IsTrue(triangleLocationRow == TriangleLocationRow.A, "expected triangleLocationRow to be A");
        }

        /// <summary>
        /// Tests scenario where the input is within the bounds of the upper limit.  Should return the input parameter value.
        /// </summary>
        [TestMethod]
        public void GetAdjustedTriangleLocationRow_A()
        {
            TriangleLocationRow testRow = TriangleLocationRow.A;

            TriangleLocationRow triangleLocationRow = TriangleCoordinateUtility.GetAdjustedTriangleLocationRow(testRow);

            Assert.IsTrue(triangleLocationRow == testRow, "expected triangleLocationRow to be same as testRow");
        }

        /// <summary>
        /// Tests scenario where the input column is greater than the bounds of the upper limit.  Should return Column-12
        /// </summary>
        [TestMethod]
        public void GetAdjustedTriangleLocationColumn_GreaterThan_Twelve()
        {
            TriangleLocationColumn triangleLocationColumn = TriangleCoordinateUtility.GetAdjustedTriangleLocationColumn((TriangleLocationColumn)99);

            Assert.IsTrue(triangleLocationColumn == TriangleLocationColumn.Twelve, "expected triangleLocationRow to be Twelve");
        }

        /// <summary>
        /// Tests scenario where the input column is less than the bounds of the lower limit.  Should return Column-1
        /// </summary>
        [TestMethod]
        public void GetAdjustedTriangleLocationColumn_LessThan_One()
        {
            TriangleLocationColumn triangleLocationColumn = TriangleCoordinateUtility.GetAdjustedTriangleLocationColumn((TriangleLocationColumn)(-1));

            Assert.IsTrue(triangleLocationColumn == TriangleLocationColumn.One, "expected triangleLocationRow to be One");
        }

        /// <summary>
        /// Tests scenario where the input column is a left-side column who's 90' angle is to the left of the hypotenuse side.  Should return false.
        /// </summary>
        [TestMethod]
        public void GetIsTargetColumnRight_False()
        {
            bool isColumnRight = TriangleCoordinateUtility.GetIsTargetColumnRight(TriangleLocationColumn.One);

            Assert.IsFalse(isColumnRight, "expected isColumnRight to be False");
        }

        /// <summary>
        /// Tests scenario where the input column is a right-side column who's 90' angle is to the right of the hypotenuse side.  Should return true.
        /// </summary>
        [TestMethod]
        public void GetIsTargetColumnRight_True()
        {
            bool isColumnRight = TriangleCoordinateUtility.GetIsTargetColumnRight(TriangleLocationColumn.Two);

            Assert.IsTrue(isColumnRight, "expected isColumnRight to be True");
        }
    }
}
