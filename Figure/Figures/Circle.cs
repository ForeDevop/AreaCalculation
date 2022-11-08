namespace Figure;

/// <summary>
/// Provides methods and properties for manage a circle,
/// such as area calculation.
/// </summary>
public class Circle : Figure
{
    private double _radius;

    /// <summary>
    /// Gets the radius of a circle.
    /// </summary>
    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Radius must be non-negative!");
            _radius = value;
        }
    }

    /// <summary>
    /// Initializes a new instance of the circle.
    /// </summary>
    /// <param name="radius"></param>
    public Circle(double radius) => Radius = radius;

    /// <summary>
    /// Returns the area of a circle using formula: pi * r^2.
    /// </summary>
    /// <returns>Area of a triangle.</returns>
    protected override double CalculateArea() => Math.PI * Radius * Radius;
}

