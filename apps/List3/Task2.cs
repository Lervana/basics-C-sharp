namespace List3;

public static class Task2
{
    private const string Description =
        "Write a program that asks the user for their name, allows them to enter it,\n" +
        "and then displays it on the screen. Example:\n" +
        "> Please enter your name: Kasia\n" +
        "> Hello Kasia!";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!");
        // -----------------
    }
}