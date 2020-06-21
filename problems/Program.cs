using System;

namespace _1480
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var nums = new int[] {1,2,3,4};

            nums = solution.RunningSum(nums);

            foreach (var n in nums)
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

    
}