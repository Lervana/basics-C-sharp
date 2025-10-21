namespace List2;

public static class Task15
{
    private const string Description =
        "Perform integer division. Check the results when the actual result is a fraction.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        int a = 10;
        int b = 3;
        int c = 15;
        int d = 5;
        int e = 7;
        int f = 2;

        Console.WriteLine($"Division of {a} by {b}: {a / b}"); // Result will be 3 (fractional part is truncated)
        Console.WriteLine($"Division of {c} by {d}: {c / d}"); // Result will be 3 (exact division)
        Console.WriteLine($"Division of {e} by {f}: {e / f}"); // Result will be 3 (fractional part is truncated)
        // -----------------
    }
}