namespace FigureInformation
{
    public class Triangle : Figure
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRectangular()
        {
            if ((a * a == b * b + c * c) ||
                (b * b == a * a + c * c) ||
                (c * c == a * a + b * b))
                return true;

            return false;
        }
    }
}