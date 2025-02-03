namespace Problem_Solving;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 1, 2, 1, 2, 2, 2 };
        Console.WriteLine(ContainsDuplicate(nums));
    }

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
