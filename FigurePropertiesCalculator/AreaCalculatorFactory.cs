using FigurePropertiesCalculator.Enums;
using FigurePropertiesCalculator.Figures;
using FigurePropertiesCalculator.Figures.Interfaces;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigurePropertiesCalculatorTests")]

namespace FigurePropertiesCalculator
{
    internal static class AreaCalculatorFactory
    {
        public static IFigureAreaCalculator GetCalculator(double[] sides, CalculationType calculationType)
        {
            switch (calculationType)
            {
                case CalculationType.CircleByRadius:
                    return new CircleByRadiusCalculator(sides);

                case CalculationType.TriangleByThreeSides:
                    return new TriangleByThreeSidesCalculator(sides);

                default:
                    throw new ArgumentException("Фигура не поддерживается");
            }
        }
    }
}