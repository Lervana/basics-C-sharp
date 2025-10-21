namespace List3;

public static class Task3
{
    private const string Description =
        "Read two numbers from the console, a and b, and check which one is greater\n" +
        "(they can be equal). Example:\n" +
        "> Please enter number A: 100\n" +
        "> Please enter number B: 90\n" +
        "> The number 100 is greater than 90.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Console.Write("Please enter number A: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Please enter number B: ");
        int b = int.Parse(Console.ReadLine()!);

        if (a > b)
        {
            Console.WriteLine($"The number {a} is greater than {b}.");
        }
        else if (b > a)
        {
            Console.WriteLine($"The number {b} is greater than {a}.");
        }
        else
        {
            Console.WriteLine($"The numbers are equal ({a}).");
        }
        // -----------------
    }
}