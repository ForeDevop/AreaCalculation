namespace FigureTests;


public class FigureTests
{
    #region Circle

    /// <summary>
    /// Test for negative value of a radius.
    /// </summary>
    [Test]
    public void CircleNegativeRadiusTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }

    /// <summary>
    /// Test for the area value with correct radius data.
    /// </summary>
    [Test]
    public void CircleCalcSquareTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(new Circle(0).Area, Is.EqualTo(0));
            Assert.That(new Circle(1).Area, Is.EqualTo(Math.PI));
            Assert.That(new Circle(4).Area, Is.EqualTo(Math.PI * Math.Pow(4, 2)));
        });
    }

    #endregion

    #region Triangle

    /// <summary>
    /// Test for negative side values.
    /// </summary>
    [Test]
    public void TriangleNegativeSidesTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
    }

    /// <summary>
    /// Test for the area value with correct side values.
    /// </summary>
    [Test]
    public void TriangleCalcSquareTest()
    {
        Assert.That(new Triangle(3, 4, 5).Area, Is.EqualTo(6));
    }

    /// <summary>
    /// Test for the rectangular triangle.
    /// </summary>
    [Test]
    public void TriangleIsRightTest()
    {
        Assert.That(new Triangle(5, 3, 4).IsRight(), Is.EqualTo(true));
    }

    /// <summary>
    /// Test for the non-rectangular triangle.
    /// </summary>
    [Test]
    public void TriangleIsNotRightTest()
    {
        Assert.That(new Triangle(6, 2, 7).IsRight(), Is.EqualTo(false));
    }

    #endregion
}