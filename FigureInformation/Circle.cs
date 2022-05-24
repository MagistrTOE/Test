namespace FigureInformation
{
    public class Circle : Figure
    {
        public double R { get; private set; }

        public Circle(double radius)
        {
            R = radius;
        }

        public override double Area()
        {
            return Math.PI * R * R;
        }
    }
}
