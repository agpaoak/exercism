using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> names = new List<string>();
    Random rand = new Random();
    public Robot()
    {
        names.Add(Name = GetName());
    }
    public string Name
    {
        get;
        private set;
    }

    public void Reset()
    {
        Name = GetName();
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
        string tempName = String.Empty;
        
        do
        {
            tempName = GetRandChar() + 
                            GetRandChar() + 
                            GetRandInt();

        } while(names.Contains(tempName));

        return tempName;
    }

}