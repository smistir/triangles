using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrianglesApplication.Models;
using TrianglesApplication.Extensions;
using TrianglesApplication.Models.Enums;

namespace TrianglesApplicationTest.ExtensionTests
{
    [TestClass]
    public class TriangleCoordinateExtensionTests
    {
        #region ConvertToTriangleLocation

        /// <summary>
        /// Test scenario where the TriangleCoordinates are Invalid
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_Invalid()
        {
            TriangleCoordinates triangleCoordinates = null;

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNull(triangleLocation);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnOne()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 10, 0, 0, 10, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }


        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnTwo()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 0, 0, 0, 10, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Two, "expected column Two, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnThree()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 10, 10, 0, 20, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Three, "expected column Three, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnFour()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 0, 10, 0, 20, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Four, "expected column Four, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnFive()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 10, 20, 0, 30, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Five, "expected column Five, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnSix()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 0, 20, 0, 30, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Six, "expected column Six, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnSeven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 10, 30, 0, 40, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Seven, "expected column Seven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnEight()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 0, 30, 0, 40, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eight, "expected column Eight, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnNine()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 10, 40, 0, 50, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Nine, "expected column Nine, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnTen()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 0, 40, 0, 50, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Ten, "expected column Ten, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnEleven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 10, 50, 0, 60, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eleven, "expected column Eleven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowA & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowA_ColumnTwelve()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 0, 50, 0, 60, 10);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.A, "expected row A");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Twelve, "expected column Twelve, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnOne()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 20, 0, 10, 10, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnTwo()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 10, 0, 10, 10, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Two, "expected column Two, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnThree()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 20, 10, 10, 20, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Three, "expected column Three, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnFour()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 10, 10, 10, 20, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Four, "expected column Four, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnFive()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 20, 20, 10, 30, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Five, "expected column Five, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnSix()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 10, 20, 10, 30, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Six, "expected column Six, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnSeven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 20, 30, 10, 40, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Seven, "expected column Seven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnEight()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 10, 30, 10, 40, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eight, "expected column Eight, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnNine()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 20, 40, 10, 50, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Nine, "expected column Nine, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnTen()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 10, 40, 10, 50, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Ten, "expected column Ten, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnEleven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 20, 50, 10, 60, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eleven, "expected column Eleven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowB & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowB_ColumnTwelve()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 10, 50, 10, 60, 20);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.B, "expected row B");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Twelve, "expected column Twelve, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnOne()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 30, 0, 20, 10, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnTwo()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 20, 0, 20, 10, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Two, "expected column Two, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnThree()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 30, 10, 20, 20, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Three, "expected column Three, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnFour()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 20, 10, 20, 20, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Four, "expected column Four, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnFive()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 30, 20, 20, 30, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Five, "expected column Five, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnSix()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 20, 20, 20, 30, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Six, "expected column Six, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnSeven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 30, 30, 20, 40, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Seven, "expected column Seven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnEight()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 20, 30, 20, 40, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eight, "expected column Eight, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnNine()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 30, 40, 20, 50, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Nine, "expected column Nine, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnTen()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 20, 40, 20, 50, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Ten, "expected column Ten, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnEleven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 30, 50, 20, 60, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eleven, "expected column Eleven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowC & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowC_ColumnTwelve()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 20, 50, 20, 60, 30);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.C, "expected row C");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Twelve, "expected column Twelve, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnOne()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 40, 0, 30, 10, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnTwo()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 30, 0, 30, 10, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Two, "expected column Two, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnThree()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 40, 10, 30, 20, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Three, "expected column Three, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnFour()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 30, 10, 30, 20, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Four, "expected column Four, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnFive()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 40, 20, 30, 30, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Five, "expected column Five, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnSix()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 30, 20, 30, 30, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Six, "expected column Six, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnSeven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 40, 30, 30, 40, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Seven, "expected column Seven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnEight()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 30, 30, 30, 40, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eight, "expected column Eight, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnNine()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 40, 40, 30, 50, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Nine, "expected column Nine, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnTen()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 30, 40, 30, 50, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Ten, "expected column Ten, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnEleven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 40, 50, 30, 60, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eleven, "expected column Eleven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowD & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowD_ColumnTwelve()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 30, 50, 30, 60, 40);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.D, "expected row D");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Twelve, "expected column Twelve, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnOne()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 50, 0, 40, 10, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnTwo()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 40, 0, 40, 10, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Two, "expected column Two, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnThree()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 50, 10, 40, 20, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Three, "expected column Three, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnFour()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 40, 10, 40, 20, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Four, "expected column Four, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnFive()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 50, 20, 40, 30, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Five, "expected column Five, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnSix()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 40, 20, 40, 30, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Six, "expected column Six, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnSeven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 50, 30, 40, 40, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Seven, "expected column Seven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnEight()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 40, 30, 40, 40, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eight, "expected column Eight, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnNine()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 50, 40, 40, 50, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Nine, "expected column Nine, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnTen()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 40, 40, 40, 50, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Ten, "expected column Ten, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnEleven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 50, 50, 40, 60, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eleven, "expected column Eleven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowE & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowE_ColumnTwelve()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 40, 50, 40, 60, 50);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.E, "expected row E");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Twelve, "expected column Twelve, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column1
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnOne()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 60, 0, 50, 10, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.One, "expected column 1");
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column2
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnTwo()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 50, 0, 50, 10, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Two, "expected column Two, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column3
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnThree()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 60, 10, 50, 20, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Three, "expected column Three, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column4
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnFour()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 50, 10, 50, 20, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Four, "expected column Four, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column5
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnFive()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(20, 60, 20, 50, 30, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Five, "expected column Five, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column6
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnSix()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 50, 20, 50, 30, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Six, "expected column Six, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column7
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnSeven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(30, 60, 30, 50, 40, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Seven, "expected column Seven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column8
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnEight()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 50, 30, 50, 40, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eight, "expected column Eight, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column9
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnNine()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(40, 60, 40, 50, 50, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Nine, "expected column Nine, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column10
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnTen()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 50, 40, 50, 50, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Ten, "expected column Ten, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column11
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnEleven()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(50, 60, 50, 50, 60, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Eleven, "expected column Eleven, but got " + triangleLocation.TriangleLocationColumn);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are for a Triangle in RowF & Column12
        /// </summary>
        [TestMethod]
        public void ConvertToTriangleLocation_RowF_ColumnTwelve()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 50, 50, 50, 60, 60);

            TriangleLocation triangleLocation = triangleCoordinates.ConvertToTriangleLocation();

            Assert.IsNotNull(triangleLocation);            
            Assert.IsTrue(triangleLocation.TriangleLocationRow == TriangleLocationRow.F, "expected row F");
            Assert.IsTrue(triangleLocation.TriangleLocationColumn == TriangleLocationColumn.Twelve, "expected column Twelve, but got " + triangleLocation.TriangleLocationColumn);
        }

        #endregion

        #region IsValid

        /// <summary>
        /// Tests scenario where the input coordinates are invalid at VertexOne
        /// </summary>
        [TestMethod]
        public void IsValid_VertexOne_Invalid()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 10, 0, 0, 10, 10);

            bool isValid = triangleCoordinates.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are invalid at VertexTwo
        /// </summary>
        [TestMethod]
        public void IsValid_VertexTwo_Invalid()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 10, 10, 10, 10, 10);

            bool isValid = triangleCoordinates.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are invalid at VertexThree
        /// </summary>
        [TestMethod]
        public void IsValid_VertexThree_Invalid()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, 10, 0, 0, 0, 0);

            bool isValid = triangleCoordinates.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are invalid due to exceeding the bounds of the lower limit
        /// </summary>
        [TestMethod]
        public void IsValid_OutOfBounds_LowerLimit()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(0, -10, 0, 0, -10, -10);

            bool isValid = triangleCoordinates.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are invalid due to exceeding the bounds of the upper limit
        /// </summary>
        [TestMethod]
        public void IsValid_OutOfBounds_UpperLimit()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(60, 70, 60, 60, 70, 70);

            bool isValid = triangleCoordinates.IsValid();

            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// Tests scenario where the input coordinates are valid
        /// </summary>
        [TestMethod]
        public void IsValid_True()
        {
            TriangleCoordinates triangleCoordinates = new TriangleCoordinates(10, 0, 0, 0, 10, 10);

            bool isValid = triangleCoordinates.IsValid();

            Assert.IsTrue(isValid);
        }

        #endregion
    }
}
