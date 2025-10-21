namespace List2;

public static class Task5
{
    private const string Description =
        "Create two string variables, firstName and lastName.\n" +
        "Combine them into a single variable, fullName, and display the result.";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 5, Description);

        // ---- Content ---- 
        string firstName = "John";
        string lastName = "Doe";

        // Examle A
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"Full name: {fullName}");
        
        // Examle B 
        Console.WriteLine($"Full name: {firstName} {lastName}");
        // -----------------
    }
}