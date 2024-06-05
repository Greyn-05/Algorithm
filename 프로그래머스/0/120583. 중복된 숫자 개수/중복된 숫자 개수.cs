using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int answer = 0;
        
        foreach (int num in array)
        {
            if (num - n == 0)
            {
                answer++;
            }
        }
        return answer;
    }
}