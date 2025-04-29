public class Solution
{
    public bool Solution(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (seen.Contains(num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 2, 3, 1 };
        bool result = solution.Solution(nums);
        Console.WriteLine(result); // Output: True
    }
}