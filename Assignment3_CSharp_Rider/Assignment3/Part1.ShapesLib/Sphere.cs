using System;

namespace Tut3_s28662;

public class Sphere : IShape
{
    private readonly double _radius;

    public Sphere(double radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be non-negative.");

        _radius = radius;
    }

    public double CalculateArea()
    {
        return 4 * Math.PI * Math.Pow(_radius, 2);
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }
}
