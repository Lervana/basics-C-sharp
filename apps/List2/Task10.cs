namespace List2;

public static class Task10
{
    private const string Description =
        "Create a program that checks whether a given year is\n" +
        "a leap year and informs the user of the result.";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 10, Description);

        // ---- Content ---- 
        var random = new Random();
        int year = random.Next(1900, 2101); // Random year between 1900 and 2100

        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"The year {year} is{(isLeapYear ? "" : " not")} a leap year.");
        // -----------------
    }
}