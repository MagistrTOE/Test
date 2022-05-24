using FigureInformation;
using Xunit;

public class TestFigure
{
    [Fact]
    public void TestMethodBySquareTriangle()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act

        var figure = (Figure)triangle;
        var ValueArea= figure.Area();

        // Assert
        Assert.Equal(6, ValueArea);
    }

    [Fact]
    public void TestMethodBySquareCircle()
    {
        // Arrange
        var circle = new Circle(5);

        // Act
        var figure = (Figure)circle;
        var ValueArea = figure.Area();

        // Assert
        Assert.Equal(Math.PI*25, ValueArea);
    }

    [Fact]
    public void TestMethodByIsRectangular1()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var info = triangle.IsRectangular();

        // Assert
        Assert.True(info);
    }

    [Fact]
    public void TestMethodByIsRectangular2()
    {
        // Arrange
        var triangle = new Triangle(5, 5, 5);

        // Act
        var info = triangle.IsRectangular();

        // Assert
        Assert.False(info);
    }
}

