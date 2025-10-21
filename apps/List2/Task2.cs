namespace List2;

public static class Task2
{
    private const string Description =
        "Write a program that displays the string \"1234\".\nAdd comments to the program: thumbnail lines and a multi-line comment.";

    public static void Execute(int listNumber)
    {
        TaskDescription.ShowDescription(listNumber + "-" + 2, Description);

        // ---- Content ---- 
        Console.WriteLine("1234");
        // -----------------

        /*
         * This is
         * example
         * multiline
         * comment :)
         */
    }
}