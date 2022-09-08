# FigurePropertiesCalculator
# Использование
Для вычисления площади фигуры (на данный момент треугольник по трем сторонам и круг по радиусу) необходимо вызвать метод CalculateArea(double[] sides, CalculationType figureType), где sides - стороны фигуры, figureType - тип вычислений (на данный момент - треугольник по трем сторонам - TriangleByThreeSides и круг по радиусу - CircleByRadius
Для вычисления, является ли треугольник прямоугольным необходимо вызвать метод IsTriangleRightAngled(double[] sides), где sides - стороны треугольника.
# Расширение
Для добавления новго вычислителя площадинеобходимо создать новый калькулятор, рализовать интерфейс IFigureAreaCalculator и добавить его в CalculationType
