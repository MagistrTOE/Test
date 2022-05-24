namespace FigureInformation
{
    public class Figure
    {
        public IFigure figure { get; set; }

        public Figure(double a, double b, double c)
        {
            figure = new Triangle(a, b, c);
        }

        public Figure(double r)
        {
            figure = new Circle(r);
        }

        public double AreaFigure()
        {
            return figure.Area();
        }

        public string InfoFigure()
        {
            return figure.Info();
        }

    }
}
