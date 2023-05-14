using System.Collections.Generic;
/*
    Given an integer array nums, return true if any value appears at least twice in the array, 
    and return false if every element is distinct.
*/
class Solution
{
    public Solution() { }
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> checkDuplicates = new HashSet<int>();
        foreach (int x in nums)
        {
            if (checkDuplicates.Contains(x))
            {
                return true;
            }
            else
            {
                checkDuplicates.Add(x);
            }
        }
        return false;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] testCase1 = { 1, 2, 3, 1 };
        int[] testCase2 = { 1, 2, 3, 4 };
        int[] testCase3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.WriteLine(solution.ContainsDuplicate(testCase1)); // True
        Console.WriteLine(solution.ContainsDuplicate(testCase2)); // False
        Console.WriteLine(solution.ContainsDuplicate(testCase3)); // True
    }
}
