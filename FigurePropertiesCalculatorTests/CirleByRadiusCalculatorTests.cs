using FigurePropertiesCalculator.Figures;
using NUnit.Framework;
using System;

namespace FigurePropertiesCalculator
{
    public class CirleByRadiusCalculatorTests
    {
        #region ctor tests

        [Test]
        public void CircleByRadiusCalculator_ParameterIsZero_ThrowsException()
        {
            double[] param = new double[] { 0 };
            Assert.Throws<ArgumentException>(() => new CircleByRadiusCalculator(param));
        }

        [Test]
        public void CircleByRadiusCalculator_ParameterLessThanZero_ThrowsException()
        {
            double[] param = new double[] { -1 };
            Assert.Throws<ArgumentException>(() => new CircleByRadiusCalculator(param));
        }

        [Test]
        public void CircleByRadiusCalculator_MoreParametersThanRequired_ThrowsException()
        {
            double[] param = new double[] { 1,2 };
            Assert.Throws<ArgumentException>(() => new CircleByRadiusCalculator(param));
        }

        [Test]
        public void CircleByRadiusCalculator_ZeroParametersSpecified_ThrowsException()
        {
            double[] param = new double[] { };
            Assert.Throws<ArgumentException>(() => new CircleByRadiusCalculator(param));
        }

        [Test]
        public void CircleByRadiusCalculator_ParameterOk()
        {
            double[] param = new double[] { 1 };
            Assert.DoesNotThrow(() => new CircleByRadiusCalculator(param));
        }

        #endregion ctor tests

        [Test]
        public void CalculateArea_ReturnsDouble()
        {
            // Arrange
            double[] param = new double[] { 2 };

            // Act
            CircleByRadiusCalculator circleCalculator = new CircleByRadiusCalculator(param);
            double areaViaCalculator = circleCalculator.CalculateArea();
            double currentlyCalculatedArea = Math.PI * Math.Pow(param[0], 2); ;

            // Assert
            Assert.IsTrue(areaViaCalculator == currentlyCalculatedArea);
        }
    }
}