# Assignment 3 – Basic Unit Testing (C# / NUnit)

This solution contains two independent parts implemented in C# and designed to be opened in JetBrains Rider or any recent .NET IDE.

## Structure

- `Part1.ShapesLib` – class library with geometric figures (`IShape`, `Sphere`, `Cylinder`, `Rectangle`, `Cube`).
- `Part1.ShapesTests` – NUnit test project with unit tests for all geometric classes, including edge cases and invalid input.
- `Part2.Calculator` – console application containing `Calculator.cs` and `Program.cs`.
- `Part2.CalculatorTests` – NUnit test project for the calculator implementation.

## How to run (Rider)

1. Open **Assignment3** folder in JetBrains Rider.
2. Let Rider restore NuGet packages (NUnit, test SDK, etc.).
3. Build the solution.
4. Run tests:
   - Open the *Unit Tests* window.
   - Run all tests or the individual test projects `Part1.ShapesTests` and `Part2.CalculatorTests`.

You can also run the calculator console app (`Part2.Calculator`) to manually try different inputs.

## CLI (optional)

If you have the .NET SDK installed, you can run tests from a terminal:

```bash
dotnet test Part1.ShapesTests/Part1.ShapesTests.csproj
dotnet test Part2.CalculatorTests/Part2.CalculatorTests.csproj
```

And run the calculator app with:

```bash
dotnet run --project Part2.Calculator/Part2.Calculator.csproj
```
