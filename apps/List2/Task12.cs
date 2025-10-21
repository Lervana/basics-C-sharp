namespace List2;

public static class Task12
{
    private const string Description =
        "Declare a few variables. Perform modulo division operations on them.\n" +
        "Display the results on the screen.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        int number1 = 17;
        int number2 = 5;
        double number3 = 10.5;
        int number4 = 3;

        Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
        Console.WriteLine($"{number3} % {number4} = {number3 % number4}");
        Console.WriteLine($"{number2} % {number4} = {number2 % number4}");
        // -----------------
    }
}