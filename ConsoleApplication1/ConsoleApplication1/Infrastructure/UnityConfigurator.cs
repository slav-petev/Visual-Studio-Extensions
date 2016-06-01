using System.Diagnostics;
using ConsoleApplication1.Input;
using Microsoft.Practices.Unity;

namespace ConsoleApplication1.Infrastructure
{
    public static class UnityConfigurator
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IInputReader, FileInputReader>("Debug");
            container.RegisterType<IInputReader, ConsoleInputReader>("Release");

            container.RegisterType<IInputParser, InputParser>(
                new InjectionConstructor(
                    new ResolvedParameter<IInputReader>(Constants.ProgramMode)));
        }
    }
}