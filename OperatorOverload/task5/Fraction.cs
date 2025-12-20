namespace Fraction;

internal class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString() => $"{Numerator}/{Denominator}";

    public int Numerator
    {
        get => numerator;
        set => numerator = value;
    }

    public int Denominator
    {
        get => denominator;
        set
        {
            if (value == 0)
                throw new Exception("Denominator cannot be zero");

            denominator = value;
        }
    }

    public static Fraction operator + (Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int newDenominator = a.Denominator * b.Denominator;

        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static Fraction operator - (Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        int newDenominator = a.Denominator * b.Denominator;

        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static Fraction operator * (Fraction a, Fraction b)
    {
        int newNumerator = a.Numerator * b.Numerator;
        int newDenominator = a.Denominator * b.Denominator;

        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static Fraction operator / (Fraction a, Fraction b)
    {
        if (b.Numerator == 0)
            throw new DivideByZeroException("Division by zero is not allowed");

        int newNumerator = a.Numerator * b.Denominator;
        int newDenominator = a.Denominator * b.Numerator;

        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
    }

    public static bool operator !=(Fraction a, Fraction b) => !(a == b);

    public Fraction Reduce()
    {
        var gcd = Gcd(Numerator, Denominator);
        return new Fraction(Numerator / gcd, Denominator / gcd);
    }

    public static int Gcd(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

}
