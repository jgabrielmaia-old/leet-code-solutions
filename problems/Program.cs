using System;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new LeetSolution();

            var result = solution.DefangIPaddr("255.100.50.0");
            Console.WriteLine(result);
        }
    }
}

