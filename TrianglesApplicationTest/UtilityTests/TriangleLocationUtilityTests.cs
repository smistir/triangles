using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;
using TrianglesApplication.Utilities;

namespace TrianglesApplicationTest.UtilityTests
{
    [TestClass]
    public class TriangleLocationUtilityTests
    {
        /// <summary>
        /// Tests scenario where the input int-based coordinate value is greater than the bounds of the upper limit.  Should return 60 (the upper limit) 
        /// </summary>
        [TestMethod]
        public void GetAdjustedCoordinateValue_GreaterThanLimit()
        {
            int coordinateValue = TriangleLocationUtility.GetAdjustedCoordinateValue(99);

            Assert.IsTrue(coordinateValue == 60, "expected coordinateValue to be 60");
        }

        /// <summary>
        /// Tests scenario where the input int-based coordinate value is less than the bounds of the lower limit.  Should return 0 (the lower limit)
        /// </summary>
        [TestMethod]
        public void GetAdjustedCoordinateValue_LessThanLimit()
        {
            int coordinateValue = TriangleLocationUtility.GetAdjustedCoordinateValue(-1);

            Assert.IsTrue(coordinateValue == 0, "expected coordinateValue to be 0");
        }

        /// <summary>
        /// Tests scenario where the input int-based coordinate value is where the coordinate value is within the bounds of the upper and lower limits but
        /// the value isn't at one of the 10's based intervals values (0, 10, 20, ..., 60).  Value should be Adjusted to the Floor of the interval.
        /// </summary>
        [TestMethod]
        public void GetAdjustedCoordinateValue_InRange_NotAtOffset()
        {
            int coordinateValue = TriangleLocationUtility.GetAdjustedCoordinateValue(57);

            Assert.IsTrue(coordinateValue == 50, "expected coordinateValue to be 50");
        }

        /// <summary>
        /// Tests scenario where input Triangle Coordinates is NULL.  Should return False
        /// </summary>
        [TestMethod]
        public void GetIsTargetColumnRight_Null()
        {
            bool isTargetRight = TriangleLocationUtility.GetIsTargetColumnRight(null);

            Assert.IsFalse(isTargetRight, "expected isTargetRight to be false");
        }

        /// <summary>
        /// Tests scenario where the input triangle is a left-side triangle who's 90' is left of its hypotenuse side
        /// </summary>
        [TestMethod]
        public void GetIsTargetColumnRight_False()
        {
            bool isTargetRight = TriangleLocationUtility.GetIsTargetColumnRight(new TriangleCoordinates(0, 10, 0, 0, 10, 10));

            Assert.IsFalse(isTargetRight, "expected isTargetRight to be false");
        }

        /// <summary>
        /// Tests scenario where the input triangle is a right-side triangle who's 90' is right of its hypotenuse side
        /// </summary>
        [TestMethod]
        public void GetIsTargetColumnRight_True()
        {
            bool isTargetRight = TriangleLocationUtility.GetIsTargetColumnRight(new TriangleCoordinates(10, 0, 0, 0, 10, 10));

            Assert.IsTrue(isTargetRight, "expected isTargetRight to be false");
        }

        /// <summary>
        /// Tests scenario where the input triangle is a left-side triangle who's 90' is left of its hypotenuse side, and the assigned column should not be shifted
        /// </summary>
        [TestMethod]
        public void GetShiftedTriangleLocationColumn_NotShifted()
        {
            TriangleLocationColumn shiftedColumn = TriangleLocationUtility.GetShiftedTriangleLocationColumn(TriangleLocationColumn.One, new TriangleCoordinates(0, 10, 0, 0, 10, 10));

            Assert.IsTrue(shiftedColumn == TriangleLocationColumn.One, "expected shiftedColumn to be TriangleLocationColumn.One");
        }

        /// <summary>
        /// Tests scenario where the input triangle is a right-side triangle who's 90' is right of its hypotenuse side, and the assigned column should be shifted
        /// to the right-side
        /// </summary>
        [TestMethod]
        public void GetShiftedTriangleLocationColumn_Shifted()
        {
            TriangleLocationColumn shiftedColumn = TriangleLocationUtility.GetShiftedTriangleLocationColumn(TriangleLocationColumn.One, new TriangleCoordinates(10, 0, 0, 0, 10, 10));

            Assert.IsTrue(shiftedColumn == TriangleLocationColumn.Two, "expected shiftedColumn to be TriangleLocationColumn.Two");
        }
    }
}
