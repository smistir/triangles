using System.Runtime.Serialization;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplication.Models
{
    /// <summary>
    /// Represents a TriangleLocation using Row and Column
    /// </summary>
    [DataContract]
    public class TriangleLocation
    {
        /// <summary>
        /// The Row of the TriangleLocation
        /// </summary>
        [DataMember]
        public TriangleLocationRow TriangleLocationRow { get; set; }

        /// <summary>
        /// The Column of the TriangleLocation
        /// </summary>
        [DataMember]
        public TriangleLocationColumn TriangleLocationColumn { get; set; }

        /// <summary>
        /// Default constructor (needed for serialization)
        /// </summary>
        public TriangleLocation() { }

        /// <summary>
        /// Constructor that sets the Row and Column of the TriangleLocation
        /// </summary>
        /// <param name="triangleLocationRow"></param>
        /// <param name="triangleLocationColumn"></param>
        public TriangleLocation(TriangleLocationRow triangleLocationRow, TriangleLocationColumn triangleLocationColumn)
        {
            this.TriangleLocationRow = triangleLocationRow;
            this.TriangleLocationColumn = triangleLocationColumn;
        }
    }
}