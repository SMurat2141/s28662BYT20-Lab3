using System;

namespace Tut2_s20123;

/// <summary>
/// Represents a right circular cylinder.
/// </summary>
public class Cylinder : IShape
{
    private readonly double _radius;
    private readonly double _height;

    public Cylinder(double radius, double height)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be non-negative.");
        if (height < 0)
            throw new ArgumentOutOfRangeException(nameof(height), "Height must be non-negative.");

        _radius = radius;
        _height = height;
    }

    public double CalculateArea()
    {
        // Surface area: 2πr(r + h)
        return 2 * Math.PI * _radius * (_radius + _height);
    }

    public double CalculateVolume()
    {
        // Volume: πr^2 h
        return Math.PI * Math.Pow(_radius, 2) * _height;
    }
}
