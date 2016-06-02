using System;
using ReadZeroTestsFromFile.ProblemSolving.Input;

namespace ReadZeroTestsFromFile.ProblemSolving
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
            var currentInput = _inputParser.ParseNextInput();
            while (!currentInput.IsEmpty)
            {
                var currentOutput = GenerateOutputForCurrentInput(currentInput);

                Console.WriteLine(currentOutput);
                currentInput = _inputParser.ParseNextInput();
            }
        }

        protected abstract string GenerateOutputLineForCurrentInputLine(string currentInputLine);

        private Output.Output GenerateOutputForCurrentInput(Input.Input currentInput)
        {
            var output = new Output.Output();

            var currentInputLine = currentInput.GetNextInputLine();
            while (!string.IsNullOrEmpty(currentInputLine))
            {
                var currentOutputLine = GenerateOutputLineForCurrentInputLine(currentInputLine);
                output.AddOutputLine(currentOutputLine);

                currentInputLine = currentInput.GetNextInputLine();
            }

            return output;
        }
    }
}