using System;

public class Solution
{
    public int[] solution(int money)
    {
        int coffee = money / 5500;
        int remain = money % 5500;
        
        int[] answer = new int[] { coffee, remain };

        return answer;
    }
}