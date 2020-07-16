using System;
using System.String;

public class Robot
{
     
    public Robot(string name) => Name = name;

    public string Name 
    {
        get => locationname;
        set => locationname = value;
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}