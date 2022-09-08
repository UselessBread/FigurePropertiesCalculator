using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigurePropertiesCalculatorTests")]

namespace FigurePropertiesCalculator.Figures
{
    internal class CircleCalculator : IFigureAreaCalculator, IParametersValidityChecker
    {
        private readonly double _radius;

        public CircleCalculator(double[] sides)
        {
            CheckIfParametersValid(sides);
            _radius = sides[0];
        }

        public double CalculateArea() =>
            Math.PI * Math.Pow(_radius, 2);

        /// <summary>
        /// Проверка валидности сторон треугольника
        /// </summary>
        /// <param name="sides">Радус</param>
        /// <exception cref="ArgumentException"></exception>
        /// <remarks>Радиус должен быть > 0</remarks>
        public void CheckIfParametersValid(double[] sides)
        {
            if (sides.Length != 1)
                throw new ArgumentException("Неверное количество сторон передано");

            if (sides[0] <= 0)
                throw new ArgumentException("Радиус должен быть > 0");
        }
    }
}