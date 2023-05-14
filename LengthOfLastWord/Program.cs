class Solution
{
    public Solution() { }
    public int LengthOfLastWord(string s)
    {
            s = s.TrimEnd();
            string[] splitString = s.Split(' ');
            return splitString[splitString.Length - 1].Length;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.LengthOfLastWord("Hello World"));
    }
}
