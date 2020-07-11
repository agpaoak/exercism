using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;


public static class Pangram
{

    private static readonly char[] alpha =  "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    public static bool IsPangram(string input)
    {
        if (String.IsNullOrEmpty(input) || input.Length < 26)
        {
            return false;
        }
        else
        {
            foreach(var c in alpha)
            {
                if (!(input.ToLower().Contains(c)))
                {
                    return false;
                }
            }
            return true;
        }
    }
    
=======

public static class Pangram
{
    private static readonly char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); 

    public static bool IsPangram(string input)
    {
        if (String.IsNullOrEmpty(input) || input.Length < 26)
        {
            return false;
        }
        else
        {
            foreach (var c in alpha)
            {
                if (!(input.ToLower().Contains(c)))
                {
                    return false;
                }
            }
            return true;
        }
    }
>>>>>>> 2aaca39938f022a0e11ad838d87f208f196a5610
}
