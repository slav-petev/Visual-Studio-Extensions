namespace ReadZeroTestsFromFile.ProblemSolving.Output
{
    public interface IOutputWriter
    {
        void WriteOutput<TOutput>(TOutput output);
    }
}