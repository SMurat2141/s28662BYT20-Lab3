using System;

namespace Tut3_s28662;

public class Rectangle : IShape
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(double length, double width)
    {
        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length), "Length must be non-negative.");
        if (width < 0)
            throw new ArgumentOutOfRangeException(nameof(width), "Width must be non-negative.");

        _length = length;
        _width = width;
    }

    public double CalculateArea()
    {
        return _length * _width;
    }

    public double CalculateVolume()
    {
        return 0;
    }
}
