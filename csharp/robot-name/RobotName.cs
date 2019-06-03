using System;

public class Robot
{

    private string _name;
    public string Name
    {
        get
        {
            return _name = "AA001";
        }
    }

    public void Reset()
    {
        _name = string.Empty;
    }
}