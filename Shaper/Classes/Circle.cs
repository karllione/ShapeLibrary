namespace Shaper.Classes
{
    public class Circle
    {
        public double radius { get; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
