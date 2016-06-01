using System.Collections.Generic;

namespace ConsoleApplication1.Input
{
    public class Input
    {
        private readonly LinkedList<string> _inputLines =
            new LinkedList<string>();

        public IEnumerable<string> InputLines => _inputLines;

        public bool IsEmpty => _inputLines.Count == 0;

        public void AddInputLine(string inputLine)
        {
            _inputLines.AddLast(inputLine);
        }

        public string GetNextLine()
        {
            if (_inputLines.Count == 0)
            {
                return null;
            }

            var line = _inputLines.First.Value;
            _inputLines.RemoveFirst();
            return line;
        }
    }
}