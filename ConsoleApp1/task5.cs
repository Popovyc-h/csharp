Console.Write("Enter day: ");
int day = int.Parse(Console.ReadLine());

Console.Write("Enter month: ");
int month = int.Parse(Console.ReadLine());
if (month < 1 || month > 12)
{
    Console.WriteLine("Error! Please enter a month from 1 to 12");
    return;
}

string season = "";
if (month == 12 || month == 1 || month == 2)
    season = "Winter";
else if (month == 3 || month == 4 || month == 5)
    season = "Spring";
else if (month == 6 || month == 7 || month == 8)
    season = "Summer";
else if (month == 9 || month == 10 || month == 11)
    season = "Autumn";

Console.Write("Enter year: ");
int year = int.Parse(Console.ReadLine());

DateTime date = new DateTime(year, month, day);
string dayOfWeek = date.DayOfWeek.ToString();

Console.WriteLine($"{season} {dayOfWeek}");
