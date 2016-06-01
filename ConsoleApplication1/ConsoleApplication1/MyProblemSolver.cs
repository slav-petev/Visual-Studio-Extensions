using System;
using ConsoleApplication1.Input;

namespace ConsoleApplication1
{
    public class MyProblemSolver : ProblemSolver
    {
        public MyProblemSolver(IInputParser inputParser) : base(inputParser)
        {
        }

        protected override void ProcessNextInputLine(string inputLine)
        {
            if (inputLine.Length < 20)
            {
                var paddedString = inputLine.PadRight(20, '*');

                Console.WriteLine(paddedString);
            }
            else
            {
                Console.WriteLine(inputLine.Substring(0, 20));
            }
        }
    }
}