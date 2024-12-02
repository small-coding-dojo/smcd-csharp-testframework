// Idea:
// 1. Instantiate Runner
// 2. Tell the runner which class(es) contain tests
// 3. Runner.Execute()
// 3.1 Identify the Tests by scanning the test classes for TestAttribute
// 3.2 ...
// 3.3 Output message: x tests executed

namespace TestFramework.Tests;

public static class Program
{
    public static void Main(string[] args)
    {
        var writer = new TestOutputWriter();
        var subject = new TestRunner(writer);

        subject.Execute();

        if (writer.Message != "0 tests executed")
        {
            Console.WriteLine("Test failed");
        }
        else
        {
            Console.WriteLine("Test successful");
        }
    }
}

public class TestOutputWriter : IWriter
{
    public string Message { get; set; } = "";

    public void Write(string input)
    {
        Message = input;
    }
}
