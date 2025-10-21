using System;

namespace List2;

public static class Task8
{
    private const string Description =
        "Write a program that calculates the area of a rectangle.\n" +
        "The values for a and b should be \"random.\" The variables representing\n" +
        "the entered values should be of type double. The result should be displayed\n" +
        " with two decimal places of precision.";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 8, Description);

        // ---- Content ---- 
        var random = new Random();

        double a = random.NextDouble() * 100; // Random width between 0 and 100
        double b = random.NextDouble() * 100; // Random height between 0 and 100

        double area = a * b;

        Console.WriteLine($"Rectangle dimensions: {a:F2} x {b:F2}");
        Console.WriteLine($"Area: {area:F2}");
        // -----------------
    }
}