namespace List2;

public static class Task14
{
    private const string Description =
        "Change the code from the Task13 so that the ++ operator is replaced with the –- operator.\n" +
        "Then analyze the resulting program and check whether the output is the same as\n" +
        "what appears on the screen after running the code.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        int x = 1, y;
        
        Console.WriteLine(--x);
        Console.WriteLine(x--);
        Console.WriteLine(x);
        
        y = x--;
        
        Console.WriteLine(y);
        
        y = --x;
        
        Console.WriteLine(--y);
        // -----------------
    }
}