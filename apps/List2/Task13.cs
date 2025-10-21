namespace List2;

public static class Task13
{
    private const string Description =
        "Analyze the code below. Don't run the program, but think about what\n" +
        "the sequence of numbers will be. Then, after running the code, check your guess.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        int x = 1, y;
        
        Console.WriteLine(++x);
        Console.WriteLine(x++);
        Console.WriteLine(x);
        
        y = x++;
        
        Console.WriteLine(y);
        
        y = ++x;
        
        Console.WriteLine(++y);
        // -----------------
    }
}