using TrianglesApplication.Helpers;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;
using TrianglesApplication.Utilities;

namespace TrianglesApplication.Extensions
{
    /// <summary>
    /// Extensions for TriangleLocation
    /// </summary>
    public static class TriangleLocationExtension
    {
        /// <summary>
        /// Converts a TriangleLocation to a TriangleCoordinates
        /// </summary>
        /// <param name="triangleLocation"></param>
        /// <returns></returns>
        public static TriangleCoordinates ConvertToTriangleCoordinates(this TriangleLocation triangleLocation)
        {
            TriangleCoordinates triangleCoordinates = null;

            if (triangleLocation.IsValid())
            {
                TriangleLocationRow targetRow = TriangleCoordinateUtility.GetAdjustedTriangleLocationRow(triangleLocation.TriangleLocationRow);
                TriangleLocationColumn targetColumn = TriangleCoordinateUtility.GetAdjustedTriangleLocationColumn(triangleLocation.TriangleLocationColumn);
                bool isTargetColumnRightSide = TriangleCoordinateUtility.GetIsTargetColumnRight(targetColumn);

                int rowBlock = (int)targetRow * TriangleApplicationConstants.INTERVAL;
                int columnBlock = targetColumn < TriangleLocationColumn.Three ? 0 : ((int)targetColumn / 2) * TriangleApplicationConstants.INTERVAL;

                int v1x = isTargetColumnRightSide ? columnBlock + TriangleApplicationConstants.INTERVAL : columnBlock;
                int v1y = isTargetColumnRightSide ? rowBlock : rowBlock + TriangleApplicationConstants.INTERVAL;
                int v2x = columnBlock;
                int v2y = rowBlock;
                int v3x = columnBlock + TriangleApplicationConstants.INTERVAL;
                int v3y = rowBlock + TriangleApplicationConstants.INTERVAL;

                triangleCoordinates = new TriangleCoordinates(v1x, v1y, v2x, v2y, v3x, v3y);
            }

            return triangleCoordinates;
        }

        /// <summary>
        /// Verifies that the TriangleLocation is a valid location with correct Row and Column values
        /// </summary>
        /// <param name="triangleLocation"></param>
        /// <returns></returns>
        public static bool IsValid(this TriangleLocation triangleLocation)
        {
            return triangleLocation != null && 
                triangleLocation.TriangleLocationRow >= TriangleLocationRow.A && triangleLocation.TriangleLocationRow <= TriangleLocationRow.F &&
                triangleLocation.TriangleLocationColumn >= TriangleLocationColumn.One && triangleLocation.TriangleLocationColumn <= TriangleLocationColumn.Twelve;
        }
    }
}