namespace List2;

public static class Task23
{
    private const string Description =
        "Write a program that asks the user to enter a number (not necessarily\n" +
        "an integer) and prints its integer part.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        // Changed to use random values instead of user input for example purposes
        Random random = new Random();
        double number = random.NextDouble() * 100; // Random number between 0 and 100
        Console.WriteLine($"Generated number: {number}");
        
        int integerPart = (int)number;
        Console.WriteLine($"The integer part is: {integerPart}");
        // -----------------
    }
}
