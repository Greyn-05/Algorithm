using System;

public class Example
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string result = (n % 2 == 0) ? $"{n} is even" : $"{n} is odd";

        Console.WriteLine(result);
    }
}