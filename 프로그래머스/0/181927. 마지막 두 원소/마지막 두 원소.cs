using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int last = num_list[num_list.Length - 1];
        int secondLast = num_list[num_list.Length - 2];
        
        List<int> answer = new List<int>(num_list);
        
        if (last > secondLast)
        {
            answer.Add(last - secondLast);
        }
        else if (last <= secondLast)
        {
            answer.Add(last*2);
        }
        
        return answer.ToArray();
    }
}