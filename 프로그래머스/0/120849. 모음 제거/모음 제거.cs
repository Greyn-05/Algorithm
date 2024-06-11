using System;
using System.Text;

public class Solution
{
    public string solution(string my_string)
    {
        string vowels = "aeiouAEIOU";
        StringBuilder answer = new StringBuilder();
        
        foreach (char c in my_string)
        {
            if (!vowels.Contains(c))
            {
                answer.Append(c);
            }
        }
        
        return answer.ToString();
    }
}