namespace List3;

public static class Task8
{
    private const string Description = "Write a program that asks the user to enter two integers, performs arithmetic\n" +
                                       "operations (+, -, *, /, %) on these numbers, and displays the results. Example:\n" +
                                       "> A: 50\n" +
                                       "> B: 10\n" +
                                       "> A + B = 50 + 10 = 60\n" +
                                       "> A - B = 50 - 10 = 40\n" +
                                       "> A * B = 50 * 10 = 500\n" +
                                       "> A / B = 50 / 10 = 5\n" +
                                       "> A % B = 50 % 10 = 0";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Console.Write("Enter first number (A): ");
        
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        Console.Write("Enter second number (B): ");
       
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return;
        }

        Console.WriteLine($"A + B = {a} + {b} = {a + b}");
        Console.WriteLine($"A - B = {a} - {b} = {a - b}");
        Console.WriteLine($"A * B = {a} * {b} = {a * b}");
        Console.WriteLine($"A / B = {a} / {b} = {a / b}");
        Console.WriteLine($"A % B = {a} % {b} = {a % b}");
        // -----------------
    }
}