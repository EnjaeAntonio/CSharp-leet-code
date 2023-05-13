class Solution
{
    public Solution() { }
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] wordChars = words[i].ToCharArray();
            Array.Reverse(wordChars);
            words[i] = new string(wordChars);
        }
        string asString = string.Join(" ", words);
        Console.WriteLine(asString);
        return asString;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.ReverseWords("Let's take LeetCode contest");

    }
}
