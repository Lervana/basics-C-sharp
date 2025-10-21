namespace List2;

public static class Task9
{
    private const string Description =
        "Write a program that checks whether a given integer is even\n" +
        "or odd and displays an appropriate message.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        var random = new Random();
        int number = random.Next(1, 101); // Random number between 1 and 100

        bool isEven = number % 2 == 0;

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"The number is {(isEven ? "even" : "odd")}");
        // -----------------
    }
}