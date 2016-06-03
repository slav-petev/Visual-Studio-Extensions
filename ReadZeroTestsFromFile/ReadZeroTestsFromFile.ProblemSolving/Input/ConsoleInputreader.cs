using System;

namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public class ConsoleInputReader : IInputReader
    {
        public string ReadNextInputLine()
        {
            return Console.ReadLine();
        }
    }
}