using FigurePropertiesCalculator.Figures.Interfaces;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FigurePropertiesCalculatorTests")]

namespace FigurePropertiesCalculator.Figures
{
    /// <summary>
    /// Вычисление параметров тругольника по трем сторонам
    /// </summary>
    internal class TriangleByThreeSidesCalculator : IFigureAreaCalculator, IParametersValidityChecker, ITriangleRightAngled
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public TriangleByThreeSidesCalculator(double[] sides)
        {
            CheckIfParametersValid(sides);

            _firstSide = sides[0];
            _secondSide = sides[1];
            _thirdSide = sides[2];
        }

        /// <summary>
        /// Проверка валидности сторон треугольника
        /// </summary>
        /// <param name="sides">Стороны треугольника</param>
        /// <exception cref="ArgumentException"></exception>
        /// <remarks>Поддерживается только треугольник с тремя сторонами.
        /// Стороны должны быть >0 и удовлетворять условию a + b > c && a + c > b || b + c > a</remarks>
        public void CheckIfParametersValid(double[] sides)
        {
            if (sides.Length != 3)
                throw new ArgumentException("Неверное количество сторон передано");

            double firstSide = sides[0];
            double secondSide = sides[1];
            double thirdSide = sides[2];

            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Стороны треугольника должны быть > 0");

            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide ||
                            secondSide + thirdSide <= firstSide)
                throw new ArgumentException("Труегольник не валиден.");
        }

        public double CalculateArea()
        {
            double perimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(perimeter * (perimeter - _firstSide) * (perimeter - _secondSide) * (perimeter - _thirdSide));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным?
        /// </summary>
        /// <returns>true - прямоугольный, false - не содержит прямого угла</returns>
        public bool IsRightAngled()
        {
            double squaredFirstSide = Math.Pow(_firstSide, 2);
            double squaredSecondSide = Math.Pow(_secondSide, 2);
            double squaredThirdSide = Math.Pow(_thirdSide, 2);

            return squaredFirstSide == squaredSecondSide + squaredThirdSide ||
                squaredSecondSide == squaredFirstSide + squaredThirdSide ||
                squaredThirdSide == squaredFirstSide + squaredSecondSide;
        }
    }
}