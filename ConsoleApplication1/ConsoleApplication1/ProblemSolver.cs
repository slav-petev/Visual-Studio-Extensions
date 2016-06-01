using System;
using ConsoleApplication1.Input;

namespace ConsoleApplication1
{
    public abstract class ProblemSolver
    {
        private readonly IInputParser _inputParser;

        protected ProblemSolver(IInputParser inputParser)
        {
            _inputParser = inputParser;
        }
        
        public void SolveProblem()
        {
            var nextInput = _inputParser.GetNextInput();
            while (!nextInput.IsEmpty)
            {
                ProcessNextInputLine(nextInput.GetNextLine());

                nextInput = _inputParser.GetNextInput();
            }
        }

        protected abstract void ProcessNextInputLine(string inputLine);
    }
}