using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        
        if (n%7 < 7)
        {
            answer = n/7 +1;
        }
        if (n%7 == 0 || n%7 >= 7)
        {
            answer = n/7;
        }

        return answer;
    }
}