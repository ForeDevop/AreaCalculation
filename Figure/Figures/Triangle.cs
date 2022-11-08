namespace Figure;

/// <summary>
/// Provides methods and properties for manage a triangle,
/// such as area calculation, checking for squarness.
/// </summary>
public class Triangle : Figure
{
    private double _side1;
    private double _side2;
    private double _side3;

    /// <summary>
    /// Gets the length of a first side.
    /// </summary>
    public double Side1
    {
        get => _side1;
        set => _side1 = CheckSideLength(value);
    }

    /// <summary>
    /// Gets the length of a second side.
    /// </summary>
    public double Side2
    {
        get => _side2;
        set => _side2 = CheckSideLength(value);
    }

    /// <summary>
    /// Gets the length of a third side.
    /// </summary>
    public double Side3
    {
        get => _side3;
        set => _side3 = CheckSideLength(value);
    }

    /// <summary>
    /// Initializes a new instance of the triangle.
    /// </summary>
    /// <param name="side1">First side of a triangle</param>
    /// <param name="side2">Second side of a triangle</param>
    /// <param name="side3">Third side of a triangle</param>
    public Triangle(double side1, double side2, double side3)
    {
        CheckSideCompliance(side1, side2, side3);

        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    /// <summary>
    /// Returns the length of a side of a triangle if its value is valid.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Length of a side of a triangle.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private double CheckSideLength(double value) =>
        value < 0
            ? throw new ArgumentOutOfRangeException("Side must be non-negative!")
            : value;

    /// <summary>
    /// Check the length of a sides of a triangle is valid. 
    /// Throw an exeption for invalid side lengths.
    /// </summary>
    /// <param name="side1">First side of a triangle</param>
    /// <param name="side2">Second side of a triangle</param>
    /// <param name="side3">Third side of a triangle</param>
    private void CheckSideCompliance(double side1, double side2, double side3)
    {
        if (side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2)
            ThrowSideComplianceException();
    }

    /// <summary>
    /// Throw an exception with description if sides of a triangle is not valid.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private void ThrowSideComplianceException()
    {
        throw new ArgumentOutOfRangeException("Length of one side must be less than sum of two others!");
    }

    /// <summary>
    /// Returns the area of a triangle using Heron's formula.
    /// </summary>
    /// <returns>Area of a triangle.</returns>
    protected override double CalculateArea()
    {
        var halfPerimeter = (Side1 + Side2 + Side3) / 2.0;

        var firstCoef = halfPerimeter - Side1;
        var secondCoef = halfPerimeter - Side2;
        var thirdCoef = halfPerimeter - Side3;

        return Math.Sqrt(halfPerimeter * firstCoef * secondCoef * thirdCoef);
    }

    /// <summary>
    /// Check for squareness of a triangle using Pifagor's rule.
    /// </summary>
    /// <returns>true if right triangle; otherwise, false.</returns>
    public bool IsRight()
    {
        var sides = new[] { Side1, Side2, Side3 };

        Array.Sort(sides);
        var hypotenuseSquared = Math.Pow(sides[2], 2);
        var cathetusSumSquared = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);

        return hypotenuseSquared == cathetusSumSquared;
    }
}

