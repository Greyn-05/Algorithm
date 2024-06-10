using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int multiple = 1;
        int sum = 0;
        
        foreach (int n in num_list)
        {
            multiple *= n;
            sum += n;
        }
        
        int sumSquare = sum * sum;
        
        if (multiple < sumSquare)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}