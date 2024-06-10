using System;
using System.Text;

public class Solution
{
    public string solution(string my_string, int[] index_list)
    {
        StringBuilder answer = new StringBuilder();
        
        foreach (int index in index_list)
        {
            answer.Append(my_string[index]);
        }
        
        return answer.ToString();
    }
}