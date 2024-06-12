using System;

public class Solution
{
    public int solution(int a, int b)
    {
        string ab = a.ToString() + b.ToString();
        int aabb = int.Parse(ab);
        int answer = 0;
        
        if (aabb == 2*a*b)
        {
            answer = aabb;
        }
        else if (aabb > 2*a*b)
        {
            answer = aabb;
        }
        else
        {
            answer = 2*a*b;
        }

        return answer;
    }
}