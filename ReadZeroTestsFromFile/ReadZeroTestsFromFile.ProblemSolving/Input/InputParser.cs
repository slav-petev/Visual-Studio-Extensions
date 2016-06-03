namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public class InputParser : IInputParser
    {
        private const string InputTerminator = "-";

        private readonly IInputReader _inputReader;

        public InputParser(IInputReader inputReader)
        {
            _inputReader = inputReader;
        }

        public Input ParseNextInput()
        {
            var nextInput = new Input();

            var nextInputLine = _inputReader.ReadNextInputLine();
            while (!string.IsNullOrEmpty(nextInputLine) && 
                nextInputLine != InputTerminator)
            {
                nextInput.AddInputLine(nextInputLine);

                nextInputLine = _inputReader.ReadNextInputLine();
            }

            return nextInput;
        }
    }
}