using System;

namespace ReadZeroTestsFromFile.ProblemSolving.Output
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteOutput(Output output)
        {
            Console.WriteLine(output);
        }
    }
}