using System;

public class Robot
{
    private string _name;
    public Robot()
    {
        Name =  GetRandChar() + 
                GetRandChar() + 
                GetRandInt();
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public void Reset()
    {
        Name =  GetRandChar() + 
                GetRandChar() + 
                GetRandInt();
    }

    private string GetRandChar()
    {
        var rand = new Random();
        return ((char)('a' + rand.Next(0,26))).ToString().ToUpper();
    }

    private string GetRandInt()
    {
        var rand = new Random();
        return rand.Next(999).ToString().PadLeft(3,'0');
    }

}