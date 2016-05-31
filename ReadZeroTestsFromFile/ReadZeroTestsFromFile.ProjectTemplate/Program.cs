using System;
using System.Diagnostics;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        //Not to be submitted to Judge
        SetInputStream();

        string currentZerotestInput = Console.ReadLine();
        while (currentZerotestInput != null)
        {
            currentZerotestInput = Console.ReadLine();
        }
    }

    [Conditional("DEBUG")]
    private static void SetInputStream()
    {
        Console.SetIn(new StreamReader(@"../../Input/Input.txt"));
    }
}
