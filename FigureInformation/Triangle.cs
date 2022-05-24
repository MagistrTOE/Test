namespace FigureInformation
{
    internal class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c; 
        }

        public double Area()
        {
            double p = (A + B + C) / 2;
            
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public string Info()
        {
            bool Form = false;
            
            if ((A * A == B * B + C * C)||
                (B * B == A * A + C * C)||
                (C * C == A * A + B * B))
                Form = true;

            return $"Вид фигуры: {nameof(Triangle)}, Прямоугольный: {Form}";
        }
    }
}