class Solution
{
    public Solution() { }
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = nums.Concat(nums).ToArray();

        for (int i = 0; i < 2; i++)
        {
            foreach (int j in nums)
            {
                ans.Append(j);
                return ans;
            }
        }
        return ans;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
    }
}
