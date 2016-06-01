using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Infrastructure;
using Microsoft.Practices.Unity;
using ReadZeroTestsFromFile.ProblemSolving.Input;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            TextFileInputReader x;
            try
            {
                x = new TextFileInputReader("asdasda");
            }
            catch (Exception)
            {
                
            }
            

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                Console.WriteLine(assembly.FullName);
                var pbta = assembly.GetName().GetPublicKeyToken();
                var str = Encoding.Default.GetString(pbta);
                Console.WriteLine(str);
            }
        }
    }
}
