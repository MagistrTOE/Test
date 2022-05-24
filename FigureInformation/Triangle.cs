namespace FigureInformation
{
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c; 
        }

        public override double Area()
        {
            double p = (A + B + C) / 2;
            
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            if ((A * A == B * B + C * C) ||
                (B * B == A * A + C * C) ||
                (C * C == A * A + B * B))
                return true;

            return false;
        }
    }
}