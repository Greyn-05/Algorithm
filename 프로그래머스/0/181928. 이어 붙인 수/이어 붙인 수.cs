using System;
using System.Text;

public class Solution
{
    public int solution(int[] num_list)
    {
        StringBuilder evenSb = new StringBuilder();
        StringBuilder oddSb = new StringBuilder();
        
        foreach (int n in num_list)
        {
            if (n % 2 == 0)
            {
                evenSb.Append(n.ToString());
            }
            else
            {
                oddSb.Append(n.ToString());
            }
        }
        
        int even = int.Parse(evenSb.ToString());
        int odd = int.Parse(oddSb.ToString());
        
        int answer = even + odd;
        return answer;
    }
}