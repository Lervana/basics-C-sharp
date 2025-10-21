namespace List3;

public static class Task5
{
    private const string Description = "Write a program that asks the user for a number of hours\n" +
                                       "and converts them to minutes and seconds.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Console.Write("Enter the number of hours: ");

        if (!double.TryParse(Console.ReadLine(), out double hours))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        double minutes = hours * 60;
        double seconds = minutes * 60;

        Console.WriteLine($"{hours} hours is equal to:");
        Console.WriteLine($"- {minutes:N0} minutes");
        Console.WriteLine($"- {seconds:N0} seconds");
        // -----------------
    }
}