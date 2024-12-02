namespace TestFramework;

public class TestRunner(IWriter writer)
{
    public void Execute()
    {
        writer.Write("0 tests executed");
    }
}