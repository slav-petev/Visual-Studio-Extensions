namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public interface IFileInputReader : IInputReader
    {
        string FilePath { get; set; }
    }
}