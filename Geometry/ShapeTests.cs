using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Geometry;

[TestFixture]
public class ShapeTests
{
    [Test]
    public void CircleArea()
    {
        var circle = new Circle(5);
        Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    [Test]
    public void TriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.GetArea(), Is.EqualTo(6).Within(1e-10));
    }

    [Test]
    public void TriangleRightTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        ClassicAssert.True(triangle.IsRightTriangle());
    }
    [Test]
    public void IsTriangleRightFalse()
    {
        var triangle = new Triangle(3, 4, 5);
        ClassicAssert.False(triangle.IsRightTriangle());
    }

    [Test]
    public void CalculateArea()
    {
        IShape circle = new Circle(5);
        IShape triangle = new Triangle(3, 4, 5);

        Assert.That(ShapeAreaCalculator.CalculateArea(circle), Is.EqualTo(Math.PI * 25).Within(1e-10));

        Assert.That(ShapeAreaCalculator.CalculateArea(triangle), Is.EqualTo(6).Within(1e-10));
    }
}