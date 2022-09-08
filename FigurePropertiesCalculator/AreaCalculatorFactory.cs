using FigurePropertiesCalculator.Enums;
using FigurePropertiesCalculator.Figures;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigurePropertiesCalculatorTests")]

namespace FigurePropertiesCalculator
{
    internal static class AreaCalculatorFactory
    {
        public static IFigureAreaCalculator GetCalculator(double[] sides, FigureTypes figureTypes)
        {
            switch (figureTypes)
            {
                case FigureTypes.Circle:
                    return new CircleCalculator(sides);

                case FigureTypes.Triangle:
                    return new TriangleCalculator(sides);

                default:
                    throw new ArgumentException("Фигура не поддерживается");
            }
        }
    }
}