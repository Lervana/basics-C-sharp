namespace List3;

public static class Task6
{
    private const string Description = "Write a program that converts a value from PLN to USD and EURO.\n" +
                                       "The value and currency should be read from the console. Use the\n" +
                                       "switch ...\ncase statement.\n" +
                                       "Example:\n" +
                                       "> Please enter a value: 100\n" +
                                       "> Please enter an input currency [PLN, USD, EUR]: USD\n" +
                                       "> Please enter a target currency [PLN, USD, EUR]: PLN\n" +
                                       "> Result: 100USD = 450PLN";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        const double usdToPln = 4.50;
        const double eurToPln = 4.70;

        Console.Write("Please enter a value: ");
        
        if (!double.TryParse(Console.ReadLine(), out double amount))
        {
            Console.WriteLine("Invalid value entered.");
            return;
        }

        Console.Write("Please enter an input currency [PLN, USD, EUR]: ");
        string inputCurrency = Console.ReadLine()?.ToUpper() ?? "";

        Console.Write("Please enter a target currency [PLN, USD, EUR]: ");
        string targetCurrency = Console.ReadLine()?.ToUpper() ?? "";

        double result = inputCurrency switch
        {
            "PLN" => targetCurrency switch
            {
                "USD" => amount / usdToPln,
                "EUR" => amount / eurToPln,
                "PLN" => amount,
                _ => -1
            },
            "USD" => targetCurrency switch
            {
                "PLN" => amount * usdToPln,
                "EUR" => amount * usdToPln / eurToPln,
                "USD" => amount,
                _ => -1
            },
            "EUR" => targetCurrency switch
            {
                "PLN" => amount * eurToPln,
                "USD" => amount * eurToPln / usdToPln,
                "EUR" => amount,
                _ => -1
            },
            _ => -1
        };

        if (result == -1)
        {
            Console.WriteLine("Invalid currency entered.");
            return;
        }

        Console.WriteLine($"Result: {amount}{inputCurrency} = {result:F2}{targetCurrency}");
        // -----------------
    }
}