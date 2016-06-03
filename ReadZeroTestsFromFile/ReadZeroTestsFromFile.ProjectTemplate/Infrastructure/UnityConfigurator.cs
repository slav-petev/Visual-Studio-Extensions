using Microsoft.Practices.Unity;
using ReadZeroTestsFromFile.ProblemSolving.Common;
using ReadZeroTestsFromFile.ProblemSolving.Input;
using ReadZeroTestsFromFile.ProblemSolving.Output;

namespace ReadZeroTestsFromFile.ProjectTemplate.Infrastructure
{
    public static class UnityConfigurator
    {
        public static void Run(IUnityContainer container)
        {
            RegisterTypes(container);
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IInputReader, TextFileInputReader>("TextFile");
            container.RegisterType<IInputReader, ConsoleInputReader>("Console");
                ;
            container.RegisterType<IInputParser, InputParser>(new InjectionConstructor(
                new ResolvedParameter<IInputReader>("$inputSource$")));
            container.RegisterType<IOutputWriter, ConsoleOutputWriter>();
        }
    }
}