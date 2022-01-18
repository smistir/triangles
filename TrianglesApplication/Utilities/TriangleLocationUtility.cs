using System;
using TrianglesApplication.Helpers;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplication.Utilities
{
    /// <summary>
    /// Utility class for TriangleLocation Calculations
    /// </summary>
    public static class TriangleLocationUtility
    {
        /// <summary>
        /// Adjust the coordinate value to intervals of 10-units accounting for Lower-Limit of 0 and UpperLimit of 60.  
        /// </summary>
        /// <param name="coordinateValue"></param>
        /// <returns></returns>
        public static int GetAdjustedCoordinateValue(int coordinateValue)
        {
            if (coordinateValue > TriangleApplicationConstants.UPPER_LIMIT)
            {
                return TriangleApplicationConstants.UPPER_LIMIT;
            }
            if (coordinateValue < TriangleApplicationConstants.LOWER_LIMIT)
            {
                return TriangleApplicationConstants.LOWER_LIMIT;
            }
            else
            {
                return (int)(Math.Floor(coordinateValue / (double)TriangleApplicationConstants.INTERVAL) * TriangleApplicationConstants.INTERVAL);
            }
        }

        /// <summary>
        /// Calculates whether this is a right-side triangle whos right-angle is to the right of the hypotenuse side
        /// </summary>
        /// <param name="triangleCoordinates"></param>
        /// <returns></returns>
        public static bool GetIsTargetColumnRight(TriangleCoordinates triangleCoordinates)
        {
            return triangleCoordinates != null && triangleCoordinates.V1X == triangleCoordinates.V3X;
        }

        /// <summary>
        /// Method to shift a left-side TriangleLocationColumn to its paired right-side TriangleLocationColumn when the triangle is a right-side triangle
        /// </summary>
        /// <param name="triangleLocationColumn"></param>
        /// <param name="triangleCoordinates"></param>
        /// <returns></returns>
        public static TriangleLocationColumn GetShiftedTriangleLocationColumn(TriangleLocationColumn triangleLocationColumn, TriangleCoordinates triangleCoordinates)
        {
            bool isTargetColumnRight = GetIsTargetColumnRight(triangleCoordinates);

            return isTargetColumnRight ? triangleLocationColumn + 1 : triangleLocationColumn;
        }
    }
}