using System;

namespace ConsoleApplication1.Input
{
    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}