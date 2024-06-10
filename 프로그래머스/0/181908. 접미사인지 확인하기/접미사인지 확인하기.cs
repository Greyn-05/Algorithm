using System;

public class Solution
{
    public int solution(string my_string, string is_suffix)
    {
        if (is_suffix.Length > my_string.Length)
        {
            return 0;
        }
        
        for (int i = 0; i < is_suffix.Length; i++)
        {
            if (my_string[my_string.Length - is_suffix.Length + i] != is_suffix[i])
            {
                return 0;
            }
        }
        
        return 1;
    }
}