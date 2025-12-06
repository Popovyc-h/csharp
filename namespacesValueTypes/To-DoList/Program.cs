namespace task;

public partial class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task("Купити хліб", "В магазині");
        Console.WriteLine(task1);
        task1.ChangeStatus(TaskStatus.InProgress);
        Console.WriteLine(task1);
    }
}
