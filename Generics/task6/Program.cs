namespace Median;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers1 = new List<int> { 5, 2, 9, 1, 6 }; // Непарна кількість чисел
        var string1 = new List<string> { "apple", "banana", "cherry", "date", "fig" }; // Непарна кількість рядків
        
        var numbers2 = new List<int> { 4, 1, 7, 9, 3, 8 }; // Парна кількість чисел
        var string2 = new List<string> { "apple", "banana", "cherry", "date" }; //Парна кількість рядків


        Console.WriteLine($"Median = {FindMedian(numbers1)}");
        Console.WriteLine($"Median = {FindMedian(numbers2)}");

        Console.WriteLine($"Median = {FindMedian(string1)}");
        Console.WriteLine($"Median = {FindMedian(string2)}");
    }

    static object FindMedian<T>(List<T> items) where T : IComparable<T>
    {
        var count = items.Count;

        if (count == 0)
            throw new ArgumentException("Collection is empty");

        var collection = new List<T>(items);
        collection.Sort();

        var isEven = count % 2 == 0;

        if (isEven)
        {
            var leftIndex = count / 2 - 1;
            var rightIndex = count / 2;

            var leftValue = collection[leftIndex];
            var rightValue = collection[rightIndex];

            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) ||
                typeof(T) == typeof(float) || typeof(T) == typeof(decimal))
            {
                var leftNumber = Convert.ToDouble(leftValue);
                var rightNumber = Convert.ToDouble(rightValue);

                return (leftNumber + rightNumber) / 2;
            }
            else
                return leftValue;
        }
        else
            return collection[count / 2];
    }
}
