using System;

public class Solution
{
    public int solution(int[] array, int height)
    {
        int answer = 0;
        
        foreach (int man in array)
        {
            if (man > height)
            {
                answer++;
            }
        }
        return answer;
    }
}