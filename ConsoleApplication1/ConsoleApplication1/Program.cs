using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Infrastructure;
using Microsoft.Practices.Unity;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var unityContainer = new UnityContainer();
            UnityConfigurator.RegisterTypes(unityContainer);

            var problemSolver = unityContainer.Resolve<MyProblemSolver>();
            problemSolver.SolveProblem();
        }
    }
}
