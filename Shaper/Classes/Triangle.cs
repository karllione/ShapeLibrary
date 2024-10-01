namespace Shaper.Classes
{
    public class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double GetArea()
        {
            double perimeter = (A + B + C) / 2;
            return Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
        }

        // Метод-проверка: прямоугольный ли треугольник
        public bool IsTriangleRectangular()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides); // сортировка сторон по возрастанию

            if (sides[0] + sides[1] <= sides[2])
            {
                throw new InvalidOperationException("Треугольник с такими сторонами не существует.");
            }

            // проверка теоремы Пифагора: c^2 = a^2 + b^2
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-9;
        }
    }
}

