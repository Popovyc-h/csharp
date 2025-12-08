namespace task5;

public class Course
{
    public string name;
    public int duration;

    public Course(string name, int duration)
    {
        this.name = name;
        this.duration = duration;
    }

    public override string ToString()
    {
        return $"Course: {name}, duration: {duration} hours";
    }
}

public class OnlineCourse : Course
{
    public string platform;

    public OnlineCourse(string name, int duration, string platform) : base(name, duration)
    {
        this.platform = platform;
    }

    public override string ToString()
    {
        return $"Course: {name}, duration: {duration} hours, platform: {platform}";
    }
}

internal class task5
{
    static void Main(string[] args)
    {
        var course = new Course("C#", 27);
        var onlineCourse = new OnlineCourse("C++", 90, "IT step");

        Console.WriteLine(course);
        Console.WriteLine(onlineCourse);
    }
}
