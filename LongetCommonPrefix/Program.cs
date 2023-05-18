class Solution
{
    public Solution() { }
    public string LongestCommonPrefix(string[] strs)
    {
        string res = "";
        for(int i = 0; i < strs[0].Length; i++)
        {
           foreach(string s in strs)
            {
                if (s[i] != strs[0][i] || i == s.Length)
                {
                    return res;
                }
            }
           res += strs[0][i];
        }
        return res;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
    }
}
