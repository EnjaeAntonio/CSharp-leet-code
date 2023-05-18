class Solution
{
    public Solution() { }
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> uniqueEmails = new HashSet<string>();

        foreach (string email in emails)
        {
            string[] stringSplit = email.Split("@");
            string local = stringSplit[0].Split("+")[0];
            string domain = stringSplit[1];
            string modifiedLocal = local.Replace(".", ""); 
            string joinEmail = modifiedLocal + "@" + domain;
            uniqueEmails.Add(joinEmail);
        }

        foreach(string email in uniqueEmails)
        {
            Console.WriteLine($"Email: {email}");
        }
        return uniqueEmails.Count; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" }));
        Console.WriteLine(solution.NumUniqueEmails(new string[] { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" }));
    }
}
