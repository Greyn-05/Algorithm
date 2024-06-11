using System;

public class Solution
{
    public bool solution(int x)
    {
        string number = x.ToString();
        int sum = 0;
        
        foreach (char c in number)
        {
            sum += (int)char.GetNumericValue(c);
        }
        
        return x % sum == 0 ? true : false;
    }
}