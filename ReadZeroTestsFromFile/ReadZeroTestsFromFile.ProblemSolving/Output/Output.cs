using System.Collections.Generic;
using System.Text;

namespace ReadZeroTestsFromFile.ProblemSolving.Output
{
    public class Output
    {
        private readonly LinkedList<string> _outputLines =
            new LinkedList<string>();

        public bool IsEmpty => _outputLines.Count == 0;

        public void AddOutputLine(string outputLine)
        {
            _outputLines.AddLast(outputLine);
        }

        public string GetNextOutputLine()
        {
            if (_outputLines.Count == 0)
            {
                return null;
            }

            var nextOutputLine = _outputLines.First.Value;
            _outputLines.Remove(nextOutputLine);

            return nextOutputLine;
        }

        public override string ToString()
        {
            var outputBuilder = new StringBuilder();
            foreach (var outputLine in _outputLines)
            {
                outputBuilder.AppendLine(outputLine);
            }

            return outputBuilder.ToString();
        }
    }
}