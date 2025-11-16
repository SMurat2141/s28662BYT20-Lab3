using System;

namespace Tut2_s20123;

/// <summary>
/// Represents a cube.
/// </summary>
public class Cube : IShape
{
    private readonly double _side;

    public Cube(double side)
    {
        if (side < 0)
            throw new ArgumentOutOfRangeException(nameof(side), "Side length must be non-negative.");

        _side = side;
    }

    public double CalculateArea()
    {
        // Surface area: 6a^2
        return 6 * Math.Pow(_side, 2);
    }

    public double CalculateVolume()
    {
        // Volume: a^3
        return Math.Pow(_side, 3);
    }
}
