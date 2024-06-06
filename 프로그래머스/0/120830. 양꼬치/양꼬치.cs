using System;

public class Solution
{
    public int solution(int n, int k)
    {
        int service = n / 10;
        int realDrink = k - service;
        
        int lamb = n * 12000;
        int drink = realDrink * 2000;
        int pay = lamb + drink;
        
        return pay;
    }
}