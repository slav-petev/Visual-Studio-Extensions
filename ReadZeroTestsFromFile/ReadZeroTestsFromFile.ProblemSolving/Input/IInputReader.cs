namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public interface IInputReader
    {
        string InputSource { get; }

        string ReadNextInputLine();
    }
}