namespace List2;

public static class Task7
{
    private const string Description =
        "Write a program that converts a value from PLN to USD and EUR.\n" +
        "Declare the following variables:\n" +
        "– pln – storing the value in PLN;\n" +
        "– usdRate – storing the dollar rate;\n" +
        "– eurRate – storing the euro rate;\n" +
        "Calculate the converted values:\n" +
        "– usdValue – the value in dollars, calculated from pln and usdRate;\n" +
        "– eurValue – the value in euro, calculated from pln and eurRate;\n" +
        "Display the results in the console using Console.WriteLine().";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        decimal pln = 100.0m;
        decimal usdRate = 0.25m;
        decimal eurRate = 0.23m;

        decimal usdValue = pln * usdRate;
        decimal eurValue = pln * eurRate;

        Console.WriteLine($"Amount in PLN: {pln:F2} PLN");
        Console.WriteLine($"Converted to USD: {usdValue:F2} USD (rate: {usdRate:F2})");
        Console.WriteLine($"Converted to EUR: {eurValue:F2} EUR (rate: {eurRate:F2})");
        // -----------------
    }
}