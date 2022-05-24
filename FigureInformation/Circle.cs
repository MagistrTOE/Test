namespace FigureInformation
{
    internal class Circle : IFigure
    {
        public double R { get; set; }

        public Circle(double radius)
        {
            R = radius;
        }

        public double Area()
        {
            return Math.PI * R * R;
        }

        public string Info()
        {
            return $"Вид фигуры: {nameof(Circle)}";
        }
    }
}
