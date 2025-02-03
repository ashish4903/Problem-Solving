using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    public static class ValidAnagram
    {
        public static bool validAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            if (s1 == s2) return true;

            Dictionary<char, int> map1 = new Dictionary<char, int>();
            Dictionary<char, int> map2 = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                map1[s1[i]] = 1 + (map1.ContainsKey(s1[i]) ? map1[s1[i]] : 0);
                map2[s2[i]] = 1 + (map2.ContainsKey(s2[i]) ? map2[s2[i]] : 0);
            }

            foreach (char c in map1.Keys)
            {
                int s2Count = map2.ContainsKey(c) ? map2[c] : 0;
                if (map1[c] != s2Count) return false;
            }
            return true;
        }
    }
}