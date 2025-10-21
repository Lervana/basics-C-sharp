namespace List2;

public static class Task3
{
    private const string Description =
        "Create variables of type int, double, string, and bool.\n" +
        "Assign them appropriate values, and then display these values on the screen\n" +
        "using > Console.WriteLine() <. What values can these types store?";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 3, Description);

        // ---- Content ---- 
        int number = 42;
        double price = 19.99;
        string message = "Hello, World!";
        bool isActive = true;

        Console.WriteLine($"Integer value: {number}");
        Console.WriteLine($"Double value: {price}");
        Console.WriteLine($"String value: {message}");
        Console.WriteLine($"Boolean value: {isActive}");
        // -----------------
    }
}