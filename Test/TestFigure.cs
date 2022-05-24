using FigureInformation;
using Xunit;

public class TestFigure
{
    [Fact]
    public void TestMethodBySquareTriangle()
    {
        // Arrange
        var figure = new Figure(3, 4, 5);

        // Act
        var Square = figure.AreaFigure();

        // Assert
        Assert.Equal(6, Square);
    }

    [Fact]
    public void TestMethodBySquareCircle()
    {
        // Arrange
        var figure = new Figure(5);

        // Act
        var Square = figure.AreaFigure();

        // Assert
        Assert.Equal(Math.PI*25, Square);
    }

    [Fact]
    public void TestMethodByInfoTriangle()
    {
        // Arrange
        var figure = new Figure(3, 4, 5);

        // Act
        var info = figure.InfoFigure();

        // Assert
        Assert.Equal("Вид фигуры: Triangle, Прямоугольный: True", info);
    }

    [Fact]
    public void TestMethodByInfoCircle()
    {
        // Arrange
        var figure = new Figure(10);

        // Act
        var info = figure.InfoFigure();

        // Assert
        Assert.Equal("Вид фигуры: Circle", info);
    }
}

