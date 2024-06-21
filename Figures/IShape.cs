namespace Figures
{
    /// <summary>
    /// Интерфейс для обязательной реализации метода расчета площади
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Метод расчета площади
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public double GetArea();
    }
}
