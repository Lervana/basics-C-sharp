namespace List3;

public static class Task4
{
    private const string Description = "Create a program that, based on the value of the age variable\n" +
                                       "read from the user, decides whether the user is an adult (18+)\n" +
                                       "or not, using an if statement.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Console.Write("Enter your age: ");
        
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Example A
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are not an adult.");
        }

        // Example B
        Console.WriteLine(age >= 18 ? "You are an adult." : "You are not an adult.");

        // -----------------
    }
}