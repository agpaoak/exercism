using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> _names = new List<string>();
    public Robot()
    {
        Reset();
    }
    public string Name
    {
        get;
        set;
    }

    public void Reset()
    {
        do
        {
            Name = GetName();
        } while(_names.Contains(Name));

        _names.Add(Name);
    }

    private string GetRandChar()
    {
        var rand = new Random();
        return ((char)('a' + rand.Next(0,26))).ToString().ToUpper();
    }

    private string GetRandInt()
    {
        var rand = new Random();
        const int MAX_NUM = 999;
        return rand.Next(MAX_NUM).ToString().PadLeft(3,'0');
    }

    private string GetName()
    {
        return GetRandChar() + 
                GetRandChar() + 
                GetRandInt();
    }

}