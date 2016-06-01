namespace ConsoleApplication1.Input
{
    public class InputParser : IInputParser
    {
        private const string TerminateInputLine = "-";

        private readonly IInputReader _inputReader;

        public InputParser(IInputReader inputReader)
        {
            _inputReader = inputReader;
        }

        public Input GetNextInput()
        {
            var nextInput = new Input();

            var nextInputLine = _inputReader.ReadLine();
            while (!string.IsNullOrEmpty(nextInputLine) && nextInputLine != TerminateInputLine)
            {
                nextInput.AddInputLine(nextInputLine);

                nextInputLine = _inputReader.ReadLine();
            }

            return nextInput;
        }
    }
}