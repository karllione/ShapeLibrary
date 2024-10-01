using Shaper.Interface;

namespace Shaper.Classes
{
    public class GetShape
    {
        public double CalculateAreaOfShape(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
