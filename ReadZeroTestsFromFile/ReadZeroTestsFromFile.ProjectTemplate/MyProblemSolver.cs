using ReadZeroTestsFromFile.ProblemSolving;
using ReadZeroTestsFromFile.ProblemSolving.Input;

namespace ReadZeroTestsFromFile.ProjectTemplate
{
    public class MyProblemSolver : ProblemSolver
    {
        public MyProblemSolver(IInputParser inputParser) : base(inputParser)
        {
        }

        protected override void GenerateOutputForCurrentInputLine(string currentInputLine)
        {
            throw new System.NotImplementedException();
        }
    }
}