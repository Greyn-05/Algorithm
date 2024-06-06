using System;

public class Solution
{
    public string solution(string rsp)
    {
        string answer = rsp.Replace('2', 't')
                           .Replace('0', 's')
                           .Replace('5', '2')
                           .Replace('t', '0')
                           .Replace('s', '5');
        return answer;
    }
}