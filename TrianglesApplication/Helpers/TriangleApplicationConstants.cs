namespace TrianglesApplication.Helpers
{
    /// <summary>
    /// A set of constant values used throughout the TrianglesApplication
    /// </summary>
    public static class TriangleApplicationConstants
    {
        /// <summary>
        /// The number of units for a row/column
        /// </summary>
        public static int INTERVAL => 10;

        /// <summary>
        /// The highest possible coordinate value
        /// </summary>
        public static int UPPER_LIMIT => 60;

        /// <summary>
        /// The lowest possible coordinate value
        /// </summary>
        public static int LOWER_LIMIT => 0;

        /// <summary>
        /// The number of Triangle-Columns in a single column of the Coordinate System.  
        /// </summary>
        public static int COLUMNS_PER_INTERVAL => 2;
    }
}