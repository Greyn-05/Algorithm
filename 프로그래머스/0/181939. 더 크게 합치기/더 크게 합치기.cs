using System;

public class Solution
{
    public int solution(int a, int b)
    {
        string strA = a.ToString();
        string strB = b.ToString();
        
        int ab = int.Parse(strA + strB);
        int ba = int.Parse(strB + strA);
        
        return Math.Max(ab, ba);
    }
}