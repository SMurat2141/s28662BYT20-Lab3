using System;
using NUnit.Framework;
using Tut3_s28662;

namespace Part1.ShapesTests;

[TestFixture]
public class SphereTests
{
    [Test]
    public void CalculateArea_Radius5_ReturnsExpected()
    {
        var sphere = new Sphere(5);
        var result = sphere.CalculateArea();

        var expected = 4 * Math.PI * Math.Pow(5, 2);
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [Test]
    public void CalculateVolume_Radius5_ReturnsExpected()
    {
        var sphere = new Sphere(5);
        var result = sphere.CalculateVolume();

        var expected = (4.0 / 3.0) * Math.PI * Math.Pow(5, 3);
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [Test]
    public void Sphere_ZeroRadius_GivesZeroAreaAndVolume()
    {
        var sphere = new Sphere(0);

        Assert.That(sphere.CalculateArea(), Is.EqualTo(0).Within(1e-9));
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(0).Within(1e-9));
    }

    [Test]
    public void Sphere_NegativeRadius_ThrowsArgumentOutOfRange()
    {
        Assert.That(() => new Sphere(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}

[TestFixture]
public class CylinderTests
{
    [Test]
    public void CalculateArea_ValidDimensions_ReturnsExpected()
    {
        var cylinder = new Cylinder(3, 7);
        var result = cylinder.CalculateArea();

        var expected = 2 * Math.PI * 3 * (3 + 7);
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [Test]
    public void CalculateVolume_ValidDimensions_ReturnsExpected()
    {
        var cylinder = new Cylinder(3, 7);
        var result = cylinder.CalculateVolume();

        var expected = Math.PI * Math.Pow(3, 2) * 7;
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [TestCase(0, 5)]
    [TestCase(5, 0)]
    [TestCase(0, 0)]
    public void Cylinder_WithZeroDimension_AllowsConstructionAndCalculates(double radius, double height)
    {
        var cylinder = new Cylinder(radius, height);

        Assert.That(cylinder.CalculateArea(), Is.GreaterThanOrEqualTo(0));
        Assert.That(cylinder.CalculateVolume(), Is.GreaterThanOrEqualTo(0));
    }

    [TestCase(-1, 1)]
    [TestCase(1, -1)]
    [TestCase(-1, -1)]
    public void Cylinder_NegativeDimension_Throws(double radius, double height)
    {
        Assert.That(() => new Cylinder(radius, height), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}

[TestFixture]
public class CubeTests
{
    [Test]
    public void CalculateArea_ValidSide_ReturnsExpected()
    {
        var cube = new Cube(4);
        var result = cube.CalculateArea();

        var expected = 6 * Math.Pow(4, 2);
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [Test]
    public void CalculateVolume_ValidSide_ReturnsExpected()
    {
        var cube = new Cube(4);
        var result = cube.CalculateVolume();

        var expected = Math.Pow(4, 3);
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [Test]
    public void Cube_ZeroSide_AreaAndVolumeZero()
    {
        var cube = new Cube(0);

        Assert.That(cube.CalculateArea(), Is.EqualTo(0).Within(1e-9));
        Assert.That(cube.CalculateVolume(), Is.EqualTo(0).Within(1e-9));
    }

    [Test]
    public void Cube_NegativeSide_Throws()
    {
        Assert.That(() => new Cube(-2), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}

[TestFixture]
public class RectangleTests
{
    [Test]
    public void CalculateArea_ValidDimensions_ReturnsExpected()
    {
        var rectangle = new Rectangle(4, 8);
        var result = rectangle.CalculateArea();

        var expected = 4 * 8;
        Assert.That(result, Is.EqualTo(expected).Within(0.001));
    }

    [Test]
    public void CalculateVolume_AlwaysZeroForRectangle()
    {
        var rectangle = new Rectangle(4, 8);

        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.0001));
    }

    [TestCase(0, 5)]
    [TestCase(5, 0)]
    [TestCase(0, 0)]
    public void Rectangle_WithZeroSide_AllowsConstruction(double length, double width)
    {
        var rectangle = new Rectangle(length, width);

        Assert.That(rectangle.CalculateArea(), Is.GreaterThanOrEqualTo(0));
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
    }

    [TestCase(-1, 1)]
    [TestCase(1, -1)]
    [TestCase(-1, -1)]
    public void Rectangle_NegativeSide_Throws(double length, double width)
    {
        Assert.That(() => new Rectangle(length, width), Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}
