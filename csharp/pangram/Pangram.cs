using System;
using System.Collections.Generic;
using System.Linq;


public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return false;
        }

        List<char> beginningLetter = new List<char>();
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length - 1; i++)
        {
            string temp = words[i];
            beginningLetter[i] = temp[0];
        }
       
        beginningLetter.ToArray.
        return true;
    }
    
}
