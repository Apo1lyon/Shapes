using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        public void Circle_double_Expected()
        {
            // arrange
            double r = - 5.5;
            // act
            Circle circle = new Circle(r);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        public void Circle_int_Expected()
        {
            // arrange
            int r = -5;
            // act
            Circle circle = new Circle(r);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        public void Circle_zero_Expected()
        {
            // arrange
            double r = 0;
            // act
            Circle circle = new Circle(r);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        public void Circle_float_Expected()
        {
            // arrange
            float r = -5.5F;
            // act
            Circle circle = new Circle(r);
        }

        [TestMethod]
        public void Square_5dot5_95dot03returned()
        {
            // arrange
            double radius = 5.5;
            double expected = 95.03;

            // act
            Circle circle = new Circle(radius);
            double? square = circle.Square();

            //assert
            Assert.AreEqual(expected, Convert.ToDouble(string.Format("{0:F2}", square)));
        }

        [TestMethod]
        public void Square_5_78dot54returned()
        {
            // arrange
            int radius = 5;
            double expected = 78.54;

            // act
            Circle circle = new Circle(radius);
            double? square = circle.Square();

            //assert
            Assert.AreEqual(expected, Convert.ToDouble(string.Format("{0:F2}", square)));
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        [TestMethod]
        public void Triangle_firstsidemin5_Expected()
        {
            //arrange
            int firstSide = -5;
            int secondSide = 3;
            int thirdSide = 4;
            double? square;
            bool? isSquareness;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            square = triangle.Square();
            isSquareness = triangle.IsSquareness;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        [TestMethod]
        public void Triangle_firstsidemin3_Expected()
        {
            //arrange
            int firstSide = 5;
            int secondSide = -3;
            int thirdSide = 4;
            double? square;
            bool? isSquareness;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            square = triangle.Square();
            isSquareness = triangle.IsSquareness;
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "Должно быть положительное число.")]
        [TestMethod]
        public void Triangle_firstsidemin4_Expected()
        {
            //arrange
            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = -4;
            double? square;
            bool? isSquareness;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            square = triangle.Square();
            isSquareness = triangle.IsSquareness;
        }

        [TestMethod]
        public void Triangle_5_3_4_Squarenesst_true()
        {
            //arrange
            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 4;
            double? square;
            bool? isSquareness;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            square = triangle.Square();
            isSquareness = triangle.IsSquareness;

            //assert
            Assert.AreEqual(true, isSquareness);

        }

        [TestMethod]
        public void Triangle_5_5_4_9dot17returned()
        {
            //arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 4;
            double? square;
            bool? isSquareness;
            double expected = 9.17;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            square = triangle.Square();
            isSquareness = triangle.IsSquareness;

            //assert
            Assert.AreEqual(expected, Convert.ToDouble(string.Format("{0:F2}",square)));
        }

        [TestMethod]
        public void Triangle_3dot4_6dot3_4dot1_6dot37returned()
        {
            //arrange
            double firstSide = 3.4;
            double secondSide = 6.3;
            double thirdSide = 4.1;
            double? square;
            bool? isSquareness;
            double expected = 6.37;

            // act
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            square = triangle.Square();
            isSquareness = triangle.IsSquareness;

            //assert
            Assert.AreEqual(expected, Convert.ToDouble(string.Format("{0:F2}", square)));
        }
    }
}