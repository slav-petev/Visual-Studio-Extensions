using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Practices.Unity;
using ReadZeroTestsFromFile.ProblemSolving.Infrastructure;
using ReadZeroTestsFromFile.ProjectTemplate;

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
