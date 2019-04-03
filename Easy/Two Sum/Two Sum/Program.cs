using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 2, 7, 11, 15 };
            int target = 17;
            Solution solution = new Solution();
            int[] result = solution.TwoSum(nums, target);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[0];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int valor = nums[i] + nums[j];
                    if (valor == target)
                    {
                        result = new[] { nums[i], nums[j] };
                    }
                }
            }

            return result;
        }
    }
}

/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
 
 */
