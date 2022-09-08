using FigurePropertiesCalculator;
using FigurePropertiesCalculator.Enums;
using FigurePropertiesCalculator.Figures;
using FigurePropertiesCalculator.Figures.Interfaces;
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
            IFigureAreaCalculator calculator = AreaCalculatorFactory.GetCalculator(param, CalculationType.TriangleByThreeSides);
            Assert.IsInstanceOf<TriangleByThreeSidesCalculator>(calculator);
        }

        [Test]
        public void GetCalculator_CircleRightRadius_ReturnsCircleCalculator()
        {
            double[] param = new double[] { 7 };
            IFigureAreaCalculator calculator = AreaCalculatorFactory.GetCalculator(param, CalculationType.CircleByRadius);
            Assert.IsInstanceOf<CircleByRadiusCalculator>(calculator);
        }

        [Test]
        public void GetCalculator_UnknownFigure_ThrowsException()
        {
            double[] param = new double[] { 7 };
            Assert.Throws<ArgumentException>(() => AreaCalculatorFactory.GetCalculator(param, CalculationType.Unknown));
        }
    }
}