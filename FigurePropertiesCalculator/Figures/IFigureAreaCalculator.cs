using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigurePropertiesCalculatorTests")]

namespace FigurePropertiesCalculator.Figures
{
    /// <summary>
    /// Интерфейс для вычисления площади фигуры
    /// </summary>
    internal interface IFigureAreaCalculator
    {
        public double CalculateArea();
    }
}