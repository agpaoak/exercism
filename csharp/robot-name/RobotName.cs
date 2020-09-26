using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> names = new List<string>();
    Random rand = new Random();
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
        } while(names.Contains(Name));

        names.Add(Name);
    }

    private string GetRandChar()
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return letters[rand.Next(letters.Length)].ToString();
    }

    private string GetRandInt()
    {

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