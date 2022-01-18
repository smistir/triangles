using System.Runtime.Serialization;

namespace TrianglesApplication.Models
{
    /// <summary>
    /// Represents a Triangle's Coordinate Values
    /// </summary>
    [DataContract]
    public class TriangleCoordinates
    {
        /// <summary>
        /// X-Coordinate of Vertext-1
        /// </summary>
        [DataMember]
        public int V1X { get; set; }

        /// <summary>
        /// Y-Coordinate of Vertex-1
        /// </summary>
        [DataMember]
        public int V1Y { get; set; }

        /// <summary>
        /// X-Coordinate of Vertext-2
        /// </summary>
        [DataMember]
        public int V2X { get; set; }

        /// <summary>
        /// Y-Coordinate of Vertex-2
        /// </summary>
        [DataMember]
        public int V2Y { get; set; }

        /// <summary>
        /// X-Coordinate of Vertext-3
        /// </summary>
        [DataMember]
        public int V3X { get; set; }

        /// <summary>
        /// Y-Coordinate of Vertex-3
        /// </summary>
        [DataMember]
        public int V3Y { get; set; }

        /// <summary>
        /// Default empty constructor (needed for Serialization)
        /// </summary>
        public TriangleCoordinates() { }

        /// <summary>
        /// Constructor setting the Vertices for a triangle
        /// </summary>
        /// <param name="v1x"></param>
        /// <param name="v1y"></param>
        /// <param name="v2x"></param>
        /// <param name="v2y"></param>
        /// <param name="v3x"></param>
        /// <param name="v3y"></param>
        public TriangleCoordinates(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            this.V1X = v1x;
            this.V1Y = v1y;
            this.V2X = v2x;
            this.V2Y = v2y;
            this.V3X = v3x;
            this.V3Y = v3y;
        }
    }
}