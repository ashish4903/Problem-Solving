using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    public static class DuplicateChecker
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in nums)
            {
                if (set.Contains(i))
                {
                    return true;
                }
                set.Add(i);
            }
            return false;
        }
    }
}