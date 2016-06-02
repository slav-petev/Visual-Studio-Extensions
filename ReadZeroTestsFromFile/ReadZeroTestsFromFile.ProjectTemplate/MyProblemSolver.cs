using ReadZeroTestsFromFile.ProblemSolving;
using ReadZeroTestsFromFile.ProblemSolving.Input;
using ReadZeroTestsFromFile.ProblemSolving.Output;

namespace ReadZeroTestsFromFile.ProjectTemplate
{
    public class MyProblemSolver : ProblemSolver
    {
        public MyProblemSolver(IInputParser inputParser, IOutputWriter outputWriter) : 
            base(inputParser, outputWriter)
        {
        }

        protected override string GenerateOutputLineForCurrentInputLine(string currentInputLine)
        {
            throw new System.NotImplementedException();
        }
    }
}