using System;
using NUnit.Framework;
using Part2.CalculatorLib;

namespace Part2.CalculatorTests;

[TestFixture]
public class CalculatorTests
{
    [TestCase(1, 2, '+', 3)]
    [TestCase(-3, 5, '+', 2)]
    [TestCase(5, 3, '-', 2)]
    [TestCase(2, 4, '*', 8)]
    [TestCase(7, 2, '/', 3.5)]
    [TestCase(1.5, 1.5, '+', 3.0)]
    public void Calculate_ValidOperations_ReturnsExpected(double a, double b, char op, double expected)
    {
        var calculator = new Calculator(a, b, op);

        var result = calculator.Calculate();

        Assert.That(result, Is.EqualTo(expected).Within(1e-9));
    }

    [Test]
    public void Calculate_DivideByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator(5, 0, '/');

        Assert.That(() => calculator.Calculate(), Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void Calculate_InvalidOperation_ThrowsArgumentException()
    {
        var calculator = new Calculator(5, 2, '%');

        Assert.That(() => calculator.Calculate(), Throws.TypeOf<ArgumentException>());
    }

    [TestCase(double.MaxValue, 1, '+')]
    [TestCase(double.MaxValue, 2, '*')]
    [TestCase(-double.MaxValue, 2, '*')]
    public void Calculate_BoundaryValues_DoesNotThrow(double a, double b, char op)
    {
        var calculator = new Calculator(a, b, op);

        Assert.DoesNotThrow(() => calculator.Calculate());
    }
}
