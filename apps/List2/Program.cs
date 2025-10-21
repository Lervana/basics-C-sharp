namespace List2;

internal static class Program
{
    private static void Main(string[] args)
    {
        var taskNumber = 2;
        Task2.Execute(2, taskNumber++);
        Task3.Execute(2, taskNumber++);
        Task4.Execute(2, taskNumber++);
        Task5.Execute(2, taskNumber++);
        Task6.Execute(2, taskNumber++);
        Task7.Execute(2, taskNumber++);
        Task8.Execute(2, taskNumber++);
        Task9.Execute(2, taskNumber++);
        Task10.Execute(2, taskNumber++);
        Task11.Execute(2, taskNumber++);
        Task12.Execute(2, taskNumber++);
    }
}
