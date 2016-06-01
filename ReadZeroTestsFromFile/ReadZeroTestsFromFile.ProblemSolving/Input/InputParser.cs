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

        public Input ParseNextInputPart()
        {
            var nextInput = new Input();

            var nextInputLine = _inputReader.ReadNextInputPart();
            while (!string.IsNullOrEmpty(nextInputLine) && 
                nextInputLine != InputTerminator)
            {
                nextInput.AddInputLine(nextInputLine);

                nextInputLine = _inputReader.ReadNextInputPart();
            }

            return nextInput;
        }
    }
}