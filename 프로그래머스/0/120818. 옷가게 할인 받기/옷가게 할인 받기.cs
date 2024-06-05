using System;

public class Solution
{
    public int solution(int price)
    {
        int answer = price;
        
        if (price >= 100000)
        {
            answer = (int)(price * 0.95);
        }
        if (price >= 300000)
        {
            answer = (int)(price * 0.9);
        }
        if (price >= 500000)
        {
            answer = (int)(price * 0.8);
        }
        
        return answer;
    }
}