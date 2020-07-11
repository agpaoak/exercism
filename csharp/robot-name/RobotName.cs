using System;
using System.Collections.Generic;

public class Robot
{

    private string _name;
    private List <string> _names = new List <string>();

    public string Name
    {
        get
        {
           return _name;
        }
        set
        {
            _name = value;
        }

    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}