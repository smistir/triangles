using System.Runtime.Serialization;

namespace TrianglesApplication.Models
{
    [DataContract]
    public class TriangleCoordinates
    {
        [DataMember]
        public int V1X { get; set; }

        [DataMember]
        public int V1Y { get; set; }

        [DataMember]
        public int V2X { get; set; }

        [DataMember]
        public int V2Y { get; set; }

        [DataMember]
        public int V3X { get; set; }

        [DataMember]
        public int V3Y { get; set; }

        public TriangleCoordinates() { }

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