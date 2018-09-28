using System;
using System.Linq;

namespace Functional.Pipeline.CodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Operators.Generate(14));
            Console.WriteLine(Extensions.Generate(14));
            Console.ReadKey();
        }
    }
}
