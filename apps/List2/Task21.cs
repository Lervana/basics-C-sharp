namespace List2;

public static class Task21
{
    private static double ReadDoubleInput()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }
    }

    private static double CalculateQuadraticFunction(double a, double b, double c, double x)
    {
        return a * x * x + b * x + c;
    }
    private const string Description =
        "Write a program that calculates the value of the quadratic function\n" +
        "y = ax2 + bx + c at a given point. The values of the coefficients\n" +
        "a, b, c, and the point x are to be supplied by the user during\n" +
        "program execution (read from the console). Ensure the program has\n" +
        "a clear interface (if possible).";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        // In this example values will be random to not wait till the user enters input
        
        Random random = new Random();
        double a = random.NextDouble() * 10 - 5;  // Random value between -5 and 5
        Console.WriteLine($"a = {a:F2}");

        double b = random.NextDouble() * 10 - 5;
        Console.WriteLine($"b = {b:F2}");

        double c = random.NextDouble() * 10 - 5;
        Console.WriteLine($"c = {c:F2}");

        double x = random.NextDouble() * 10 - 5;
        Console.WriteLine($"x = {x:F2}");

        double result = CalculateQuadraticFunction(a, b, c, x);
        Console.WriteLine($"\nResult: y = {result:F2}");
        // -----------------
    }
}
