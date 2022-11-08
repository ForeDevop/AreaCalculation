namespace Figure;

/// <summary>
/// Provides the base class for a figure.
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Gets the area of a figure.
    /// </summary>
    public double Area => CalculateArea();

    /// <summary>
    /// Returns the area of a figure.
    /// </summary>
    /// <returns>Area of a given figure.</returns>
    protected abstract double CalculateArea();
}