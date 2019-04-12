using System;

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
}
