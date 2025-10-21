namespace List2;

public static class Task18
{
    private const string Description =
        "Use the conditional operator to modify the value of any integer variable (int).\n" +
        "The conditional operator has the following syntax:\n" +
        "condition ? value1 : value2;";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        int number = new Random().Next();
        string result = number % 2 == 0 ? "even" : "odd";
        int newNumber = number % 2 == 0 ? number + 100 : number - 100;
        
        Console.WriteLine($"Number {number} is {result}. After changes: {newNumber}");
        // -----------------
    }
}
