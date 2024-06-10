using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string change = n.ToString();
        
        foreach (char c in change)
        {
            answer += (int)char.GetNumericValue(c);
        }
        
        return answer;
    }
}