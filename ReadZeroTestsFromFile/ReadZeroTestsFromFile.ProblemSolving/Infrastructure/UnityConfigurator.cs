using Microsoft.Practices.Unity;
using ReadZeroTestsFromFile.ProblemSolving.Input;
using ReadZeroTestsFromFile.ProblemSolving.Output;

namespace ReadZeroTestsFromFile.ProblemSolving.Infrastructure
{
    public static class UnityConfigurator
    {
        public static void Run(IUnityContainer container)
        {
            RegisterTypes(container);
        }

        private static void RegisterTypes(IUnityContainer container)
        {
#if DEBUG
            container.RegisterType<IInputReader, TextFileInputReader>();
#else
            container.RegisterType<IInputReader, ConsoleInputReader>();
#endif
            container.RegisterType<IInputParser, InputParser>();

            container.RegisterType<IOutputWriter, ConsoleOutputWriter>();
        }
    }
}