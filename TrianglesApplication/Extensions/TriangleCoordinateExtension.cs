using TrianglesApplication.Helpers;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;
using TrianglesApplication.Utilities;

namespace TrianglesApplication.Extensions
{
    /// <summary>
    /// Extensions for TriangleCoordinates
    /// </summary>
    public static class TriangleCoordinateExtension
    {
        /// <summary>
        /// Converts a TriangleCoordinates to a TriangleLocation
        /// </summary>
        /// <param name="triangleCoordinates"></param>
        /// <returns></returns>
        public static TriangleLocation ConvertToTriangleLocation(this TriangleCoordinates triangleCoordinates)
        {
            TriangleLocation triangleLocation = null;

            if (triangleCoordinates.IsValid())
            {
                int targetX = TriangleLocationUtility.GetAdjustedCoordinateValue(triangleCoordinates.V2X);
                int targetY = TriangleLocationUtility.GetAdjustedCoordinateValue(triangleCoordinates.V2Y);

                TriangleLocationRow triangleLocationRow = targetY == 0 ? TriangleLocationRow.A : (TriangleLocationRow)(targetY / TriangleApplicationConstants.INTERVAL);
                TriangleLocationColumn triangleLocationColumn = targetX == 0 ? TriangleLocationColumn.One : (TriangleLocationColumn)((targetX / 5));

                triangleLocationColumn = TriangleLocationUtility.GetShiftedTriangleLocationColumn(triangleLocationColumn, triangleCoordinates);

                triangleLocation = new TriangleLocation(triangleLocationRow, triangleLocationColumn);
            }

            return triangleLocation;
        }

        /// <summary>
        /// Verifies that the TriangleCoordinates item is a valid right Triangle
        /// </summary>
        /// <param name="triangleCoordinates"></param>
        /// <returns></returns>
        public static bool IsValid(this TriangleCoordinates triangleCoordinates)
        {
            return triangleCoordinates != null &&
                triangleCoordinates.V1X >= 0 && triangleCoordinates.V1X <= 60 &&
                triangleCoordinates.V1Y >= 0 && triangleCoordinates.V1Y <= 60 &&
                triangleCoordinates.V2X >= 0 && triangleCoordinates.V2X <= 60 &&
                triangleCoordinates.V2Y >= 0 && triangleCoordinates.V2Y <= 60 &&
                triangleCoordinates.V3X >= 0 && triangleCoordinates.V3X <= 60 &&
                triangleCoordinates.V3Y >= 0 && triangleCoordinates.V3Y <= 60 &&
                ((triangleCoordinates.V1X == triangleCoordinates.V2X && triangleCoordinates.V1Y == triangleCoordinates.V3Y) ||
                (triangleCoordinates.V1X == triangleCoordinates.V3X && triangleCoordinates.V1Y == triangleCoordinates.V2Y));
        }
    }
}