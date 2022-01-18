using TrianglesApplication.Helpers;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplication.Utilities
{
    /// <summary>
    /// Utility class for TrianingLocationRow items
    /// </summary>
    public static class TriangleCoordinateUtility
    {
        /// <summary>
        /// Adjust the TriangleLocationRow value to intervals of 10-units accounting for Lower-Limit of TriangleLocationRow.A and UpperLimit of TriangleLocationRow.F.  
        /// </summary>
        /// <param name="triangleLocationRow"></param>
        /// <returns></returns>
        public static TriangleLocationRow GetAdjustedTriangleLocationRow(TriangleLocationRow triangleLocationRow)
        {
            if (triangleLocationRow > TriangleLocationRow.F)
            {
                return TriangleLocationRow.F;
            }
            else if (triangleLocationRow < TriangleLocationRow.A)
            {
                return TriangleLocationRow.A;
            }
            else
            {
                return triangleLocationRow;
            }
        }

        /// <summary>
        /// Adjust the TriangleLocationRow value to intervals of 10-units accounting for Lower-Limit of TriangleLocationColumn.One and UpperLimit of TriangleLocationColumn.Twelve.  
        /// </summary>
        /// <param name="triangleLocationColumn"></param>
        /// <returns></returns>
        public static TriangleLocationColumn GetAdjustedTriangleLocationColumn(TriangleLocationColumn triangleLocationColumn)
        {
            if (triangleLocationColumn > TriangleLocationColumn.Twelve)
            {
                return TriangleLocationColumn.Twelve;
            }
            else if (triangleLocationColumn < TriangleLocationColumn.One)
            {
                return TriangleLocationColumn.One;
            }
            else
            {
                return triangleLocationColumn;
            }
        }

        /// <summary>
        /// Calculates whether this is a right-side triangle whos right-angle is to the right of the hypotenuse side by looking at a TriangleLocationColumn
        /// </summary>
        /// <param name="triangleLocationColumn"></param>
        /// <returns></returns>
        public static bool GetIsTargetColumnRight(TriangleLocationColumn triangleLocationColumn)
        {
            return (int)triangleLocationColumn % TriangleApplicationConstants.COLUMNS_PER_INTERVAL == 1;
        }
    }
}