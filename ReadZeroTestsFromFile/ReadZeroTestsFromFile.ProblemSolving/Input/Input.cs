using System.Collections.Generic;

namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public class Input
    {
        private readonly LinkedList<string> _inputLines =
            new LinkedList<string>();

        public bool IsEmpty => _inputLines.Count == 0;

        public void AddInputLine(string inputLine)
        {
            _inputLines.AddLast(inputLine);
        }

        public string GetNextInputLine()
        {
            if (_inputLines.Count == 0)
            {
                return null;
            }

            var nextInputLine = _inputLines.First.Value;
            _inputLines.RemoveFirst();

            return nextInputLine;
        }
    }
}