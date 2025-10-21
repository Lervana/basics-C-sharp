namespace List2;

public static class Task19
{
    private const string Description =
        "Use a double-slash comment to describe the following program code fragment.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        // declaring variables x and y, and assigning value 1 to x
        int x = 1, y;
        
        // using ternary operator to assign 10 to y if x equals 1, otherwise assign 20
        y = (x == 1) ? 10 : 20;
        
        // printing the value of y to the console
        Console.WriteLine(" y = " + y);
        // -----------------
    }
}
