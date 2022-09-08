using FigurePropertiesCalculator.Figures;
using NUnit.Framework;
using System;

namespace AreaCalculatorTests
{
    public class TriangleCalculatorTests
    {
        #region ctor tests

        [Test]
        public void TriangleCalculator_FirstParameterLessThanZero_ThrowsException()
        {
            double[] param = new double[] { -7, 10, 5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_SecondParameterLessThanZero_ThrowsException()
        {
            double[] param = new double[] { 7, -10, 5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_ThirdParameterLessThanZero_ThrowsException()
        {
            double[] param = new double[] { 7, 10, -5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_AllParameterLessThanZero_ThrowsException()
        {
            double[] param = new double[] { -7, -10, -5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_NotValidTriangleCalculator_FirstArgument_ThrowsException()
        {
            double[] param = new double[] { 1, 10, 5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_NotValidTriangleCalculator_SecondArgument_ThrowsException()
        {
            double[] param = new double[] { 7, 1, 5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_NotValidTriangleCalculator_ThirdArgument_ThrowsException()
        {
            double[] param = new double[] { 7, 10, 1 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_NotValidTriangleCalculator_FirstAndSecondArgument_ThrowsException()
        {
            double[] param = new double[] { 1, 1, 5 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_NotValidTriangleCalculator_SecondAndThirdArgument_ThrowsException()
        {
            double[] param = new double[] { 7, 1, 1 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_NotValidTriangleCalculator_FirstAndThirdArgument_ThrowsException()
        {
            double[] param = new double[] { 1, 10, 1 };
            Assert.Throws<ArgumentException>(() => new TriangleByThreeSidesCalculator(param));
        }

        [Test]
        public void TriangleCalculator_ValidTriangleAndParametersOk_DoesNotThrowException()
        {
            double[] param = new double[] { 7, 10, 5 };
            Assert.DoesNotThrow(() => new TriangleByThreeSidesCalculator(param));
        }

        #endregion ctor tests

        [Test]
        public void CalculateArea_ReturnsValue()
        {
            // Arrange
            double[] param = new double[] { 7, 10, 5 };
            TriangleByThreeSidesCalculator triangle = new TriangleByThreeSidesCalculator(param);

            // Act
            double firstSide = param[0];
            double secondSide = param[1];
            double thirdSide = param[2];
            double perimeter = (firstSide + secondSide + thirdSide) / 2;
            double currentlyCalculatedArea = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));

            double areaViaCalculator = triangle.CalculateArea();

            // Assert
            Assert.IsTrue(areaViaCalculator == currentlyCalculatedArea);
        }

        [Test]
        public void IsRightAngled_ReturnsTrue()
        {
            // Arrange
            double[] param = new double[] { 3, 4, 5 };
            TriangleByThreeSidesCalculator triangle = new TriangleByThreeSidesCalculator(param);

            // Act
            bool isRight = triangle.IsRightAngled();

            // Assert
            Assert.True(isRight);
        }

        [Test]
        public void IsRightAngled_ReturnsFalse()
        {
            // Arrange
            double[] param = new double[] { 7, 10, 5 };
            TriangleByThreeSidesCalculator triangle = new TriangleByThreeSidesCalculator(param);

            // Act
            bool isRight = triangle.IsRightAngled();

            // Assert
            Assert.False(isRight);
        }
    }
}