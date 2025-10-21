namespace List2;

public static class Task16
{
    private const string Description =
        "Declare a variable of type sbyte. Assign it the value 128.\n" +
        "Try compiling the resulting code. What's the result?";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        // sbyte variable;
        // variable = 128;
        // Console . WriteLine ( "variable = " + variable ) ;
        // -----------------
    }
}