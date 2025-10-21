namespace List2;

public static class Task20
{
    private const string Description =
        "Use block comments in the program code from the Task19.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        
        /* 
         * x is initialized to 1, y is declared
         * y is assigned 10 if x equals 1, otherwise 20
         * Write the value of y to the console
         */
        
        int x = 1, y;
        y = (x == 1) ? 10 : 20;
        Console.WriteLine(" y = " + y);
        // -----------------
    }
}