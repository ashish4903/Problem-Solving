using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    public static class TwoSum
    {
        public static int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (result.ContainsKey(difference))
                {
                    return new int[] { result[difference], i };
                }
                result[nums[i]] = i;
            }
            return null;
        }
    }
}