namespace xxx;

public interface IShape
{
    public double CalculateArea();
    public double CalculatePerimeter();
}

public class Circle : IShape
{
    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

public class Rectangle : IShape
{
    public double width;
    public double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}

public class Triangle : IShape
{
    public double a;
    public double b;
    public double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double CalculateArea()
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }

    public double CalculatePerimeter()
    {
        return a + b + c;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(10);
        var rectangle = new Rectangle(5, 10);
        var triangle = new Triangle(3, 4, 5);

        Console.WriteLine("Circle");
        Console.Write("Calculate area: ");
        Console.WriteLine(circle.CalculateArea());
        Console.Write("Calculate perimeter: ");
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine("\nRectangle");
        Console.Write("Calculate area: ");
        Console.WriteLine(rectangle.CalculateArea());
        Console.Write("Calculate perimeter: ");
        Console.WriteLine(rectangle.CalculatePerimeter());

        Console.WriteLine("\nTriangle");
        Console.Write("Calculate area: ");
        Console.WriteLine(triangle.CalculateArea());
        Console.Write("Calculate perimeter: ");
        Console.WriteLine(triangle.CalculatePerimeter());
    }
}
