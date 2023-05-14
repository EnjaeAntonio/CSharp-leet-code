class Solution
{
    public Solution() { }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> prevMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (prevMap.ContainsKey(diff))
            {
                return new int[] { prevMap[diff], i };
            }
            else
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
        int[] testCaseThree = { 3, 3 };

        Solution solution = new Solution();
        int[] resultOne = solution.TwoSum(testCaseOne, 9);
        int[] resultTwo = solution.TwoSum(testCaseTwo, 6);
        int[] resultThree = solution.TwoSum(testCaseThree, 6);

        Console.WriteLine(string.Join(", ", resultOne));
        Console.WriteLine(string.Join(", ", resultTwo));
        Console.WriteLine(string.Join(", ", resultThree));
    }


}
