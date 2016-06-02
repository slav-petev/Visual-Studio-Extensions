using System;

namespace ReadZeroTestsFromFile.ProblemSolving.Output
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteOutput<TOutput>(TOutput output)
        {
            Console.WriteLine(output);
        }
    }
}