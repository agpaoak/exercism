using System;
using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {

        StringBuilder sb = new StringBuilder();
        Char[] temp = input.ToCharArray();

        Array.Reverse(temp);

        foreach(var c in temp)
        {
            sb.Append(c);
        }

        return sb.ToString();
    }
}