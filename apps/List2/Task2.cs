namespace List2;

public class Task2
{
    private const string Description =
        "Write a program that displays the string \"1234\".\nAdd comments to the program: thumbnail lines and a multi-line comment.";

    public static void Execute()
    {
        TaskDescription.ShowDescription("[2.2.]", Description);

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