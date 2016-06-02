using System;
using ReadZeroTestsFromFile.ProblemSolving.Input;
using ReadZeroTestsFromFile.ProblemSolving.Output;

namespace ReadZeroTestsFromFile.ProblemSolving
{
    public abstract class ProblemSolver
    {
        private readonly IInputParser _inputParser;
        private readonly IOutputWriter _outputWriter;

        protected ProblemSolver(IInputParser inputParser, IOutputWriter outputWriter)
        {
            _inputParser = inputParser;
            _outputWriter = outputWriter;
        }

        public void SolveProblem()
        {
            var currentInput = _inputParser.ParseNextInput();
            while (!currentInput.IsEmpty)
            {
                var currentOutput = GenerateOutputForCurrentInput(currentInput);

                _outputWriter.WriteOutput(currentOutput);
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