using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglesApplication.Extensions;
using TrianglesApplication.Models;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplicationTest.ExtensionTests
{
    [TestClass]
    public class TriangleLocationExtensionTests
    {
        #region ConvertToTriangleCoordinates

        /// <summary>
        /// Tests scenario where the input TriangleLocation is Invalid
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_Invalid()
        {
            TriangleLocation triangleLocation = null;

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNull(triangleCoordinates);
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnOne()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.One);
            
            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 0, "expected 0 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnTwo()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Two);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 0, "expected 0 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnThree()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Three);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnFour()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Four);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();
                        
            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 0, "expected 0 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnFive()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Five);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnSix()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Six);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 0, "expected 0 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnSeven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Seven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnEight()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Eight);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 0, "expected 0 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnNine()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Nine);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnTen()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Ten);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();
                        
            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 0, "expected 0 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnEleven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Eleven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowA & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowA_ColumnTwelve()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.A, TriangleLocationColumn.Twelve);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 60, "expected 60 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 0, "expected 0 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 0, "expected 0 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 10, "expected 10 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnOne()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.One);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 0, "expected 0 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnTwo()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Two);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        [TestMethod]
        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column3
        /// </summary>
        public void ConvertToTriangleCoordinates_RowB_ColumnThree()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Three);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();
                        
            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnFour()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Four);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();
                        
            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnFive()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Five);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnSix()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Six);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnSeven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Seven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnEight()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Eight);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnNine()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Nine);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnTen()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Ten);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnEleven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Eleven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowB & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowB_ColumnTwelve()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.B, TriangleLocationColumn.Twelve);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 60, "expected 60 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 10, "expected 10 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 10, "expected 10 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 20, "expected 20 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnOne()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.One);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 0, "expected 0 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnTwo()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Two);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnThree()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Three);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnFour()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Four);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnFive()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Five);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnSix()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Six);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnSeven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Seven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnEight()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Eight);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnNine()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Nine);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnTen()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Ten);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnEleven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Eleven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowC & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowC_ColumnTwelve()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.C, TriangleLocationColumn.Twelve);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 60, "expected 60 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 20, "expected 20 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 20, "expected 20 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 30, "expected 30 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnOne()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.One);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();
                        
            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 0, "expected 0 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnTwo()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Two);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnThree()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Three);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnFour()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Four);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnFive()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Five);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnSix()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Six);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnSeven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Seven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnEight()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Eight);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnNine()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Nine);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnTen()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Ten);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();
                        
            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnEleven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Eleven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowD & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowD_ColumnTwelve()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.D, TriangleLocationColumn.Twelve);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 60, "expected 60 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 30, "expected 30 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 30, "expected 30 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 40, "expected 40 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnOne()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.One);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 0, "expected 0 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnTwo()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Two);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnThree()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Three);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnFour()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Four);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnFive()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Five);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnSix()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Six);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnSeven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Seven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnEight()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Eight);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnNine()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Nine);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnTen()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Ten);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnEleven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Eleven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowE & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowE_ColumnTwelve()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.E, TriangleLocationColumn.Twelve);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 60, "expected 60 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 40, "expected 40 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 40, "expected 40 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 50, "expected 50 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnOne()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.One);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 0, "expected 0 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 60, "expected 60 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnTwo()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Two);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 0, "expected 0 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 10, "expected 10 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnThree()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Three);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 10, "expected 10 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 60, "expected 60 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnFour()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Four);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 10, "expected 10 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 20, "expected 20 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnFive()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Five);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 20, "expected 20 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 60, "expected 60 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnSix()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Six);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 20, "expected 20 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 30, "expected 30 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnSeven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Seven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 30, "expected 30 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 60, "expected 60 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnEight()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Eight);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 30, "expected 30 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 40, "expected 40 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnNine()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Nine);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 40, "expected 40 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 60, "expected 60 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnTen()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Ten);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 40, "expected 40 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 50, "expected 50 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnEleven()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Eleven);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 50, "expected 50 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 60, "expected 60 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        /// <summary>
        /// Tests scenario where the input TriangleLocation is RowF & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleCoordinates_RowF_ColumnTwelve()
        {
            TriangleLocation triangleLocation = new TriangleLocation(TriangleLocationRow.F, TriangleLocationColumn.Twelve);

            TriangleCoordinates triangleCoordinates = triangleLocation.ConvertToTriangleCoordinates();

            Assert.IsNotNull(triangleCoordinates);
            Assert.IsTrue(triangleCoordinates.V1X == 60, "expected 60 but got " + triangleCoordinates.V1X + " for V1X");
            Assert.IsTrue(triangleCoordinates.V1Y == 50, "expected 50 but got " + triangleCoordinates.V1Y + " for V1Y");
            Assert.IsTrue(triangleCoordinates.V2X == 50, "expected 50 but got " + triangleCoordinates.V2X + " for V2X");
            Assert.IsTrue(triangleCoordinates.V2Y == 50, "expected 50 but got " + triangleCoordinates.V2Y + " for V2Y ");
            Assert.IsTrue(triangleCoordinates.V3X == 60, "expected 60 but got " + triangleCoordinates.V3X + " for V3X");
            Assert.IsTrue(triangleCoordinates.V3Y == 60, "expected 60 but got " + triangleCoordinates.V3Y + " for V3Y");
        }

        #endregion

        #region IsValid

        /// <summary>
        /// Tests NULL input parameter
        /// </summary>
        [TestMethod]
        public void IsValid_Null()
        {
            TriangleLocation triangleLocation = null;

            bool isValid = triangleLocation.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input parameter is less than the lower-limit
        /// </summary>
        [TestMethod]
        public void IsValid_LessThanBounds()
        {
            TriangleLocation triangleLocation = new TriangleLocation(((TriangleLocationRow)(-1)), ((TriangleLocationColumn)(-1)));

            bool isValid = triangleLocation.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input parameter is greater than the upper-limit
        /// </summary>
        [TestMethod]
        public void IsValid_GreaterThanBounds()
        {
            TriangleLocation triangleLocation = new TriangleLocation(((TriangleLocationRow)(99)), ((TriangleLocationColumn)(99)));

            bool isValid = triangleLocation.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input parameter is greater than the upper-limit
        /// </summary>
        [TestMethod]
        public void IsValid_True()
        {
            TriangleLocation triangleLocation = new TriangleLocation(((TriangleLocationRow)(1)), ((TriangleLocationColumn)(1)));

            bool isValid = triangleLocation.IsValid();

            Assert.IsTrue(isValid);
        }

        #endregion
    }
}
