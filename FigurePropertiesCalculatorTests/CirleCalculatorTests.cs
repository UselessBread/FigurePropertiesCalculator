using FigurePropertiesCalculator.Figures;
using NUnit.Framework;
using System;

namespace AreaCalculatorTests
{
    public class CirleCalculatorTests
    {
        #region ctor tests

        [Test]
        public void CircleCalculator_ParameterIsZero_ThrowsException()
        {
            double[] param = new double[] { 0 };
            Assert.Throws<ArgumentException>(() => new CircleCalculator(param));
        }

        [Test]
        public void CircleCalculator_ParameterLessThanZero_ThrowsException()
        {
            double[] param = new double[] { -1 };
            Assert.Throws<ArgumentException>(() => new CircleCalculator(param));
        }

        [Test]
        public void CircleCalculator_ParameterOk()
        {
            double[] param = new double[] { 1 };
            Assert.DoesNotThrow(() => new CircleCalculator(param));
        }

        #endregion ctor tests

        [Test]
        public void CalculateArea_ReturnsDouble()
        {
            // Arrange
            double[] param = new double[] { 2 };

            // Act
            CircleCalculator circleCalculator = new CircleCalculator(param);
            double areaViaCalculator = circleCalculator.CalculateArea();
            double currentlyCalculatedArea = Math.PI * Math.Pow(param[0], 2); ;

            // Assert
            Assert.IsTrue(areaViaCalculator == currentlyCalculatedArea);
        }
    }
}