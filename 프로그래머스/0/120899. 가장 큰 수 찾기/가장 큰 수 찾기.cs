using System;

public class Solution
{
    public int[] solution(int[] array)
    {
        int max = -1;
        int maxIndex = -1;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        
        int[] answer = new int[] {max, maxIndex};
        return answer;
    }
}