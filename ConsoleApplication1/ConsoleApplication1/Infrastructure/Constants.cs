namespace ConsoleApplication1.Infrastructure
{
    public static class Constants
    {
#if DEBUG
        public const string ProgramMode = "Debug";
#else
        public const string ProgramMode = "Release";
#endif
    }
}