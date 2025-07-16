using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Solution
    {

       
       public static bool hasDuplicate(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(nums[i]);
            }
            if (numbers.Count == nums.Length)
                return false;
            else
                return true;
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];
            for (int i = 1; i < nums.Length;i++)
            {
                result[i] = result[i - 1] + nums[i];
            }
            return result;

        }

        public static bool IsAnagram(string s, string t)
        {
            if (s == null || t == null) return false;
            if (s.Length != t.Length) return false;
            var s1 = s.ToCharArray(); 
            var t1 = t.ToCharArray(); 
            Array.Sort(s1);
             Array.Sort(t1);

            return s1.SequenceEqual(t1);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length;i++)
            {
  
                for (int j = i+1 ; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }   
                }
                
               
            }
          return new int[0];
        }
    }
}
