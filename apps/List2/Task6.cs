namespace List2;

public static class Task6
{
    private const string Description =
        "Write a program that calculates the area of a rectangle with dimensions\n" +
        "stored in variables x and y. The result is first stored in variable z\n" +
        "and then displayed.";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 6, Description);

        // ---- Content ---- 
        int x = 5;
        int y = 10;
        
        int z = x * y;

        Console.WriteLine($"The area of rectangle with dimensions {x} x {y} is: {z}");
        // -----------------
    }
}