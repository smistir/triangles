using System.Runtime.Serialization;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplication.Models
{
    [DataContract]
    public class TriangleLocation
    {
        [DataMember]
        public TriangleLocationRow TriangleLocationRow { get; set; }

        [DataMember]
        public TriangleLocationColumn TriangleLocationColumn { get; set; }

        public TriangleLocation() { }

        public TriangleLocation(TriangleLocationRow triangleLocationRow, TriangleLocationColumn triangleLocationColumn)
        {
            this.TriangleLocationRow = triangleLocationRow;
            this.TriangleLocationColumn = triangleLocationColumn;
        }
    }
}