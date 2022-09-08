using FigurePropertiesCalculator.Enums;
using FigurePropertiesCalculator.Figures;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigurePropertiesCalculatorTests")]

namespace FigurePropertiesCalculator
{
    /// <summary>
    /// Операции для фигур, доступные пользователю библиотеки
    /// </summary>
    public static class FigureOperations
    {
        public static double CalculateArea(double[] sides, FigureTypes figureType) =>
            AreaCalculatorFactory.GetCalculator(sides, figureType).CalculateArea();

        public static bool IsTriangleRightAngled(double[] sides) =>
            new TriangleCalculator(sides).IsRightAngled();
    }
}