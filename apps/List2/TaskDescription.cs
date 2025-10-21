namespace List2;

public static class TaskDescription
{
    public static void ShowDescription(string prefix, string description)
    {
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.WriteLine("[" + prefix + "]");
        Console.WriteLine(description);
        Console.WriteLine(new string('-', Console.WindowWidth));
    }
}