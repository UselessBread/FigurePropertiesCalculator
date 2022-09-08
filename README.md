# FigurePropertiesCalculator
# Использование
- Для вычисления площади фигуры (на данный момент треугольник по трем сторонам и круг по радиусу) необходимо вызвать метод CalculateArea(double[] sides, CalculationType figureType), где sides - стороны фигуры, figureType - тип вычислений (на данный момент - треугольник по трем сторонам - TriangleByThreeSides и круг по радиусу - CircleByRadius
- Для вычисления, является ли треугольник прямоугольным необходимо вызвать метод IsTriangleRightAngled(double[] sides), где sides - стороны треугольника.
# Примеры использования
- FigurePropertiesCalculator.FigureOperations.CalculateArea(new double[] { 7, 10, 5 }, FigurePropertiesCalculator.Enums.CalculationType.TriangleByThreeSides) - получение площади треугольника по трем сторонам.
- FigureOperations.IsTriangleRightAngled(new double[] { 7, 10, 5 }) - определение, является ли треугольник прямоугольным
# Расширение
Для добавления новго вычислителя площади необходимо создать новый калькулятор, рализовать интерфейс IFigureAreaCalculator и добавить его в CalculationType
