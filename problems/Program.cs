using System;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            // var runningSumProblem = new int[] {1,2,3,4};
            // var shuffleProblem = new int[] {1,2,3,4,4,3,2,1};
            int n = 4, start = 3;
            var solution = new LeetSolution();

            var result = solution.XorOperation(n, start);
            Console.WriteLine(result);
        }
    }
}

