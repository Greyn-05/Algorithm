using System;

public class Solution
{
    public int solution(int n)
    {
        for (int x = 1; x <= n; x++)
        {
            if (n % x == 1)
            {
                return x;
            }
        }
        
        int answer = 0;
        return answer;
    }
}