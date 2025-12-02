var color = new RgbColor(255, 0, 128);

Console.WriteLine(color.toHex());

var (h, s, l) = color.toHsl();
Console.WriteLine($"{h:F2}, {s:F2}, {l:F2}");

var (c, m, y, k) = color.toCmyk();
Console.WriteLine($"{c:F2}, {m:F2}, {y:F2}, {k:F2}");

struct RgbColor
{
    private int R;
    private int G;
    private int B;

    public RgbColor(int R, int G, int B)
    {
        this.R = R;
        this.G = G;
        this.B = B;
    }

    public string toHex()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }

    public (double H, double S, double L) toHsl()
    {
        double H = 0, S = 0, L = 0;

        double r = R / 255.0;
        double g = G / 255.0;
        double b = B / 255.0;

        double max = Math.Max(r, Math.Max(g, b));
        double min = Math.Min(r, Math.Min(g, b));
        double delta = max - min;

        if (delta == 0)
            H = 0;
        else
        {
            if (max == r)
                H = 60 * (((g - b) / delta) % 6);

            if (max == g)
                H = 60 * (((b - r) / delta) + 2);

            if (max == b)
                H = 60 * (((r - g) / delta) + 4);
        }

        if (H < 0)
            H += 360;

        L = (max + min) / 2;

        S = delta == 0 ? 0 : delta / (1 - Math.Abs(2 * L - 1));

        return (H, S, L);
    }

    public (double C, double M, double Y, double K) toCmyk()
    {
        double C = 0, M = 0, Y = 0, K = 0;

        double r = R / 255.0;
        double g = G / 255.0;
        double b = B / 255.0;

        K = 1 - Math.Max(r, Math.Max(g, b));

        if (K == 1)
        {
            C = 0;
            M = 0;
            Y = 0;
            return (C, M, Y, K);
        }

        C = (1 - r - K) / (1 - K);
        M = (1 - g - K) / (1 - K);
        Y = (1 - b - K) / (1 - K);

        return (C, M, Y, K);
    }
}
