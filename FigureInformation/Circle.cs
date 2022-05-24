namespace FigureInformation
{
    public class Circle : Figure
    {
        public double r { get; private set; }

        public Circle(double radius)
        {
            r = radius;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
}
