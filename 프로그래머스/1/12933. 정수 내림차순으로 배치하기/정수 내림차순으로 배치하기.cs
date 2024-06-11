using System;

public class Solution
{
    public long solution(long n)
    {
        string newNum = n.ToString();
        char [] sortNum = newNum.ToCharArray();
        
        Array.Sort(sortNum);
        Array.Reverse(sortNum);
        
        string answerNum = new string(sortNum);
        
        long answer = long.Parse(answerNum);
        return answer;
    }
}