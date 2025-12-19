namespace TemperatureArray;

internal class TemperatureArray
{
    private double[] temperature { get; }

    public TemperatureArray()
    {
        temperature = new double[7];
    }

    public double this[int index]
    {
        get => temperature[index];

        set { temperature[index] = value; }
    }

    public double CalculateWeeklyAverageTemperature()
    {
        double sum = 0.0;

        for (int i = 0; i < temperature.Length; i++)
            sum += temperature[i];

        double result = sum / temperature.Length;

        return result;
    }
}
