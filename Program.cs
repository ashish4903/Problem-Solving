namespace Problem_Solving;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //int[] nums = { 1, 2, 1, 2, 2, 2 };
        //Console.WriteLine(DuplicateChecker.ContainsDuplicate(nums));

        string s1 = "anagram";
        string s2 = "margana";

        Console.WriteLine(ValidAnagram.validAnagram(s1, s2));

    }
}
