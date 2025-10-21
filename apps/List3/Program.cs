namespace List3;

internal static class Program
{
    private static void Main(string[] args)
    {
        const int listNumber = 3;
        const int startTask = 2;
        const int tasksCount = 26;
        
        Console.WriteLine($"Picks the task to execute [{startTask}-{tasksCount}]:");
        var task = int.Parse(Console.ReadLine());

        if (task is < startTask or > tasksCount)
        {
            Console.WriteLine("Invalid task number");
            return;
        }

        switch (task)
        {
            case 2:
                Task2.Execute(listNumber, task);
                break;
            case 3:
                Task3.Execute(listNumber, task);
                break;
            case 4:
                Task4.Execute(listNumber, task);
                break;
            case 5:
                Task5.Execute(listNumber, task);
                break;
            case 6:
                Task6.Execute(listNumber, task);
                break;
            case 7:
                Task7.Execute(listNumber, task);
                break;
            case 8:
                Task8.Execute(listNumber, task);
                break;
            case 9:
                Task9.Execute(listNumber, task);
                break;
            case 10:
                Task10.Execute(listNumber, task);
                break;
            case 11:
                Task11.Execute(listNumber, task);
                break;
            case 12:
                Task12.Execute(listNumber, task);
                break;
            case 13:
                Task13.Execute(listNumber, task);
                break;
            case 14:
                Task14.Execute(listNumber, task);
                break;
            case 15:
                Task15.Execute(listNumber, task);
                break;
            case 16:
                Task16.Execute(listNumber, task);
                break;
            case 17:
                Task17.Execute(listNumber, task);
                break;
            case 18:
                Task18.Execute(listNumber, task);
                break;
            case 19:
                Task19.Execute(listNumber, task);
                break;
            case 20:
                Task20.Execute(listNumber, task);
                break;
            case 21:
                Task21.Execute(listNumber, task);
                break;
            case 22:
                Task22.Execute(listNumber, task);
                break;
            case 23:
                Task23.Execute(listNumber, task);
                break;
            case 24:
                Task24.Execute(listNumber, task);
                break;
            case 25:
                Task25.Execute(listNumber, task);
                break;
            case 26:
                Task26.Execute(listNumber, task);
                break;
        }
    }
}
