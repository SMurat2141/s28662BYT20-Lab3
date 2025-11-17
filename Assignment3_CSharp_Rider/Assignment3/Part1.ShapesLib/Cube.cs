using System;

namespace Tut3_s28662;

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
        return 6 * Math.Pow(_side, 2);
    }

    public double CalculateVolume()
    {
        return Math.Pow(_side, 3);
    }
}
