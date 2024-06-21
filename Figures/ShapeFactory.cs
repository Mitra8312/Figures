using Figures.Figures;

namespace Figures
{
    /// <summary>
    /// Класс фабрики для создания метода рассчета площади фигуры
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// Метод создания круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Новый экземпляр класса фигуры</returns>
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Метод создания треугольника
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона Б</param>
        /// <param name="sideC">СТорона С</param>
        /// <returns>Новый экземпляр класса треугольника</returns>
        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
