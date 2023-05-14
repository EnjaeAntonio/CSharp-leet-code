class Solution
{
    public Solution() { }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> prevMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (prevMap.ContainsKey(prevMap[diff]))
            {
                int[] newInt = new int[] { prevMap[diff], i };
                return newInt;
            } else
            {
                prevMap[nums[i]] = i;
            }
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] testCaseOne = { 2, 7, 11, 15 };
        int[] testCaseTwo = { 3, 2, 4 };
        int[] testCaseThree = { 3, 3};


        Solution solution = new Solution();
        Console.WriteLine(solution.TwoSum(testCaseOne, 9));
        Console.WriteLine(solution.TwoSum(testCaseTwo, 4));
        Console.WriteLine(solution.TwoSum(testCaseThree, 6));
    }
}
