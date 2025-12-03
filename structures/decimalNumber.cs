using System.Text;

var number = new DecimalNumber(10);
Console.Write("To binary: ");
Console.WriteLine(number.toBinary());

Console.Write("To octal: ");
Console.WriteLine(number.toOctal());

Console.Write("To hex: ");
Console.WriteLine(number.toHex());

struct DecimalNumber
{
    private int number;

    public DecimalNumber(int number)
    {
        this.number = number;
    }

    public string toBinary()
    {
        if (number == 0) 
            return "0";
        
        var sb = new StringBuilder();

        int temp = number;

        while (temp > 0)
        {
            int n = temp % 2;

            sb.Append(n);

            temp /= 2;
        }

        return new string(sb.ToString().Reverse().ToArray());
    }

    public string toOctal()
    {
        if (number == 0)
            return "0";

        var sb = new StringBuilder();

        int temp = number;

        while (temp > 0)
        {
            int n = temp % 8;

            sb.Append(n);

            temp /= 8;
        }

        return new string(sb.ToString().Reverse().ToArray());
    }

    public string toHex()
    {
        if (number == 0)
            return "0";

        var sb = new StringBuilder();

        int temp = number;

        while (temp > 0)
        {
            int n = temp % 16;

            if (n < 10)
                sb.Append(n);
            else if (n == 10)
                sb.Append("A");
            else if (n == 11)
                sb.Append("B");
            else if (n == 12)
                sb.Append("C");
            else if (n == 13)
                sb.Append("D");
            else if (n == 14)
                sb.Append("E");
            else if (n == 15)
                sb.Append("F");

            temp /= 16;
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}
