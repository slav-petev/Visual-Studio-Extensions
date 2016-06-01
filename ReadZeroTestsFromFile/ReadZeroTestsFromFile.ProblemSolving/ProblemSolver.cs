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
            var nextInput = _inputParser.ParseNextInputPart();
        }

        protected abstract void GenerateOutputForCurrentInputLine(string currentInputLine);
    }
}