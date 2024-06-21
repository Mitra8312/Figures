namespace Figures.Figures
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор для инициализации нового экземпляра класса круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Ошибка о недопустимом радиусе фигуры</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом!");
            Radius = radius;
        }

        /// <summary>
        /// Реализация метода по рассчету площади
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
