var vecA = new Vector3(2, 3, 5);
var vecB = new Vector3(1, -1, 2);

Console.WriteLine($"Multiplied: {vecA.Multiply(2)}");
Console.WriteLine($"Added: {vecA.Add(vecB)}");
Console.WriteLine($"subtracted: {vecA.Subtract(vecB)}");

struct Vector3
{
    private double X;
    private double Y;
    private double Z;

    public Vector3(double X, double Y, double Z)
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }

    public Vector3 Multiply(double scalar)
    {
        double newX = this.X * scalar;
        double newY = this.Y * scalar;
        double newZ = this.Z * scalar;

        return new Vector3(newX, newY, newZ);
    }

    public Vector3 Add(Vector3 other)
    {
        double newX = this.X + other.X;
        double newY = this.Y + other.Y;
        double newZ = this.Z + other.Z;

        return new Vector3(newX, newY, newZ);
    }

    public Vector3 Subtract(Vector3 other)
    {
        double newX = this.X - other.X;
        double newY = this.Y - other.Y;
        double newZ = this.Z - other.Z;

        return new Vector3(newX, newY, newZ);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}
