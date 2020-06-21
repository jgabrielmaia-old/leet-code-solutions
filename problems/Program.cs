using System;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            // var runningSumProblem = new int[] {1,2,3,4};
            var shuffleProblem = new int[] {1,2,3,4,4,3,2,1};

            var result = solution.Shuffle(shuffleProblem, 4);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}

public class Solution {
    
    // 1480
    public int[] RunningSum(int[] nums) {
        var result = new int[nums.Length];
        
        result[0] = nums[0];

        for(int i = 1; i < nums.Length; i++){
            result[i] = nums[i] + result[i-1];
        }

        return result;
    }

    // 1470
    public int[] Shuffle(int[] nums, int n) {
        int length = n*2;
        int[] result = new int[length];

        for(int i = 0; i < length; i+=2){
           result[i] = nums[i/2]; 
           result[i+1] = nums[n+i/2]; 
        }

        return result;
    }  
}