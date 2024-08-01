using System;
using System.Collections.Generic;

class Program1
{
    public void Main1()
    {
        string input = "hello world kartik";
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Character frequencies:");
        foreach (var item in charCount)
        {
            if (item.Value > 1)
            {
                Console.WriteLine($"Character '{item.Key}': {item.Value} times");
            }
        }
    }
}
