class Solution
{
    public Solution() { }
    public bool IsAnagram(string s, string t)
    {
        HashSet<int> countS = new HashSet<int>();
        HashSet<int> countT = new HashSet<int>();
        if (s.Length != t.Length)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                countS.Add(s[i]);
                countT.Add(t[i]);
                bool haveSameValues = countS.SetEquals(countT);
                if(haveSameValues)
                {
                    return true;
                }
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
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // True
        Console.WriteLine(solution.IsAnagram("rat", "car")); // False
    }
}
