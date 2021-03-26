using System;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new PermuteProblem();
            var result = solution.Permute(new int[2] {1,2});

            foreach (var array in result){
                foreach (var element in array)
                    Console.Write(element + "|");
                Console.WriteLine();
            }
        }
    }
}

