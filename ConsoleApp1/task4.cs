Console.Write("Enter a six-digit number: ");
int numbers = int.Parse(Console.ReadLine());

if (numbers >= 100000 && numbers <= 999999)
{
    Console.Write("Select the first digit position: ");
    int index1 = int.Parse(Console.ReadLine());

    Console.Write("Select the second digit position: ");
    int index2 = int.Parse(Console.ReadLine());

    int[] digits = new int[6];
    
    digits[0] = numbers / 100000; 
    numbers %= 100000;
    
    digits[1] = numbers / 10000; 
    numbers %= 10000;

    digits[2] = numbers / 1000; 
    numbers %= 1000;

    digits[3] = numbers / 100; 
    numbers %= 100;

    digits[4] = numbers / 10; 
    numbers %= 10;

    digits[5] = numbers;

    int temp = digits[index1 - 1];
    digits[index1 - 1] = digits[index2 - 1];
    digits[index2 - 1] = temp;

    int result = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 + digits[3] * 100 + digits[4] * 10 + digits[5];

    Console.WriteLine(result);
}
else
    Console.WriteLine("Error! The number must be six digits long.");
