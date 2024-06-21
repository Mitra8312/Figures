namespace Figures.Figures
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// СТорона А
        /// </summary>
        public double SideA { get; }
        
        /// <summary>
        /// СТорона Б
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Сторона С
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Конструктор класса треугольника для инициализации нового экземпляра класса треугольника
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона Б</param>
        /// <param name="sideC">Сторона С</param>
        /// <exception cref="ArgumentException">Сообщение о неправильной длине сторон</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны должны быть положительными!");
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник имеет неправильные длины сторон");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Метод для проверки треугольника на прямоугольность
        /// </summary>
        /// <returns>Если треугольник прямоугольный - true, иначе - false</returns>
        public bool IsRightTriangle()
        {
            double a = SideA, b = SideB, c = SideC;
            double[] sides = [a, b, c];
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
        }

        /// <summary>
        /// Валидация сторон треугольника
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона Б</param>
        /// <param name="c">Сторона С</param>
        /// <returns></returns>
        private bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}