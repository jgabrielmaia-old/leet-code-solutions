using System;

namespace problems {
    public class LeetSolution {
    
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

        // 1486
        public int XorOperation(int n, int start) {       
            int bitwise = 0;
            for(int i=0; i < n; i++, start += 2){
                bitwise ^= start;
            }   
            return bitwise;
        }

        // 1108
        public string DefangIPaddr(string address) {
            int i = address.Length -1;
            char[] newAddress = new char[address.Length+6];

            for (int j = newAddress.Length -1; i >= 0 ;)
            {
                if (address[i] == '.') {
                    newAddress[j] = ']'; 
                    newAddress[j-1] = '.'; 
                    newAddress[j-2] = '['; 
                    j-=3;
                }                  
                else 
                    newAddress[j--] = address[i];
                i--;
            }

            return new string(newAddress);
        }
    }
}