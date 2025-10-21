namespace List2;

public static class Task17
{
    private const string Description =
        "Declare a variable of type sbyte and assign it the value 127.\n" +
        "Then perform an arithmetic operation that increments the variable,\n" +
        "thus causing it to exceed its maximum value. Display the result on the screen.\n" +
        "What is the result of these operations (justify your answer)?";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        sbyte variable;
        variable = 127;
        variable++;
        Console.WriteLine(" variable= " + variable);
        // -----------------
    }
}
