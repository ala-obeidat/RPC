using System;

using IronPython.Hosting;

namespace RPC
{
    class Program
    {
        const string pythonFilePath = @"E:\Personal\RPC\calculater.py";
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[1]);

            var ipy = Python.CreateRuntime();
            dynamic calc = ipy.UseFile(pythonFilePath);
            int addition = calc.fun(num1, num2);
            
            Console.WriteLine($"Result from Python file: {addition}");
        }
    }
}
