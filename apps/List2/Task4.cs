namespace List2;

public static class Task4
{
    private const string Description =
        "Declare two variables a and b of type int and perform operations on them:\n" +
        "addition, subtraction, multiplication, and division.\n" +
        "Display the results of each operation.";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 4, Description);

        // ---- Content ---- 
        int a = 10;
        int b = 5;

        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");
        
        // -----------------
    }
}