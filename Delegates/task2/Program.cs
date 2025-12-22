    namespace SetOfMetods;

    internal class Program
    {
        public static void ShowCurrentTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        }

        public static void ShowDayOfWeek()
        {
            Console.WriteLine(DateTime.Now.ToString("dddd"));
        }

        public static double CalculateTriangleArea(double baseLength, double height) => (baseLength * height) / 2;

        public static double CalculateRectangleArea(double width, double height) => width * height; 

        static void Main(string[] args)
        {
            Action ShowTime = ShowCurrentTime;
        
            ShowTime();
        
            Console.WriteLine();
        
            ShowTime += ShowDate;
            ShowTime();
        
            Console.WriteLine();
        
            ShowTime += ShowDayOfWeek;
            ShowTime();

            Func<double, double, double> triangleArea = CalculateTriangleArea;

            Func<double, double, double> rectangleArea = CalculateRectangleArea;

        
            Console.WriteLine($"Area of ​​the triangle: {triangleArea(10, 4)}");
            Console.WriteLine($"Area of ​​the rectangle: {rectangleArea(5, 5)}");
        }
    }
