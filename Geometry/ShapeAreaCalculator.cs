namespace Geometry;

public static class ShapeAreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.GetArea();
    }
}