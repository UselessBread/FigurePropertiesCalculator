namespace FigurePropertiesCalculator.Figures
{
    /// <summary>
    /// Интерфейс для проверки валидности параметров фигуры
    /// </summary>
    internal interface IParametersValidityChecker
    {
        public void CheckIfParametersValid(double[] sides);
    }
}