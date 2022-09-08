using FigurePropertiesCalculator;
using FigurePropertiesCalculator.Enums;
using FigurePropertiesCalculator.Figures;
using NUnit.Framework;
using System;

namespace AreaCalculatorTests
{
    public class AreaCalculatorFactoryTests
    {
        [Test]
        public void GetCalculator_TriangleRightSides_ReturnsTriangleCalculator()
        {
            double[] param = new double[] { 7, 10, 5 };
            IFigureAreaCalculator calculator = AreaCalculatorFactory.GetCalculator(param, FigureTypes.Triangle);
            Assert.IsInstanceOf<TriangleCalculator>(calculator);
        }

        [Test]
        public void GetCalculator_CircleRightRadius_ReturnsCircleCalculator()
        {
            double[] param = new double[] { 7 };
            IFigureAreaCalculator calculator = AreaCalculatorFactory.GetCalculator(param, FigureTypes.Circle);
            Assert.IsInstanceOf<CircleCalculator>(calculator);
        }

        [Test]
        public void GetCalculator_UnknownFigure_ThrowsException()
        {
            double[] param = new double[] { 7 };
            Assert.Throws<ArgumentException>(() => AreaCalculatorFactory.GetCalculator(param, FigureTypes.Unknown));
        }
    }
}