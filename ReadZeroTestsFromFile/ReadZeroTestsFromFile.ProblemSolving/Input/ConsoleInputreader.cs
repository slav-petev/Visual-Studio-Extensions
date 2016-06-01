using System;

namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public class ConsoleInputreader : IInputReader
    {
        public string ReadNextInputPart()
        {
            return Console.ReadLine();
        }
    }
}