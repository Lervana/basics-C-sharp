namespace List2;

public static class Task22
{
    private const string Description =
        "Add comments to the code from the Task21 describing the functionality of each statement.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        // Create a random number generator for generating coefficient values
        Random random = new Random();

        // Generate random 'a' between -5 and 5 and display it
        double a = random.NextDouble() * 10 - 5;  // Multiply by 10 to get range -5 to 5
        Console.WriteLine($"a = {a:F2}");         // Display with 2 decimal places

        // Generate random 'b' between -5 and 5 and display it
        double b = random.NextDouble() * 10 - 5;
        Console.WriteLine($"b = {b:F2}");

        // Generate random 'c' between -5 and 5 and display it
        double c = random.NextDouble() * 10 - 5;
        Console.WriteLine($"c = {c:F2}");

        // Generate random x-coordinate between -5 and 5 and display it
        double x = random.NextDouble() * 10 - 5;
        Console.WriteLine($"x = {x:F2}");

        // Calculate the result of quadratic function f(x) = ax² + bx + c
        double result = a * x * x + b * x + c;
        
        // Display the final result with 2 decimal places
        Console.WriteLine($"\nResult: y = {result:F2}");
        // -----------------
    }
}
