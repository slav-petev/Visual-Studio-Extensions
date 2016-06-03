using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Practices.Unity;
using ReadZeroTestsFromFile.ProjectTemplate;
using ReadZeroTestsFromFile.ProjectTemplate.Infrastructure;

public class Program
{
    public static void Main()
    {
        var unityContainer = new UnityContainer();
        UnityConfigurator.Run(unityContainer);

        var problemSolver = unityContainer.Resolve<MyProblemSolver>();
        problemSolver.SolveProblem();
    }
}
