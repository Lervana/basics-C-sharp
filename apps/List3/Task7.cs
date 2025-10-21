namespace List3;

public static class Task7
{
    private const string Description = "Create a program that takes a number from the user and checks whether\n" +
                                       "it is positive, negative, or zero.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Console.Write("Please enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        string result = number switch
        {
            0 => "equal to zero",
            > 0 => "positive",
            < 0 => "negative"
        };

        Console.WriteLine($"The number {number} is {result}.");
        
        // -----------------
    }
}