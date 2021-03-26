using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace problems
{
    public class PermuteProblem {
        public IList<IList<int>> Permute(int[] nums) {       
            var result = new List<IList<int>>();
            
            if(nums.Length < 1)
                return result;
            
            var hs = new HashSet<int>();
            
            Permute(nums,hs,result);
            
            return result;
        }
    
        private void Permute(int[] nums,HashSet<int> hs,List<IList<int>> result)
        {
            if(hs.Count == nums.Length)
            {
                result.Add(hs.ToList());
            }
            else
            {
                for(int i=0;i<nums.Length;i++)
                {
                    if(!hs.Contains(nums[i]))
                    {
                        hs.Add(nums[i]);
                        Permute(nums,hs,result);
                        hs.Remove(nums[i]);
                    }
                }
            }
        }
    }
}