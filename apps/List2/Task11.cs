namespace List2;

public static class Task11
{
    
    private const string Description =
        "Write a program that converts a temperature from Celsius to Fahrenheit\n" +
        "or vice versa, depending on the setting of a boolean flag.";

    public static void Execute(int listNumber, int taskNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + taskNumber, Description);

        // ---- Content ---- 
        Random random = new Random();
        double temperature = random.Next(-50, 51);
        bool toFahrenheit = random.Next(2) == 0;

        double result = toFahrenheit 
            ? (temperature * 9 / 5) + 32
            : (temperature - 32) * 5 / 9;

        string fromUnit = toFahrenheit ? "Celsius" : "Fahrenheit";
        string toUnit = toFahrenheit ? "Fahrenheit" : "Celsius";

        Console.WriteLine($"Random temperature: {temperature}°{fromUnit}");
        Console.WriteLine($"Converted to: {result:F2}°{toUnit}");
        // -----------------
    }
}