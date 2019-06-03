using System;
using System.Text;

public class Robot
{

    private string _name;


    public Robot()
    {
        _name = this.CreateName();
    }

    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(_name))
            {
                _name = CreateName();
            }
            return _name;
        }
    }

    public void Reset()
    {
        _name = string.Empty;
    }

    private string CreateName()
    {
        var charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        const int MAXCHAR = 2;
        const int MAXNUM = 3;
        StringBuilder sb = new StringBuilder();


        for(var i = 0; i < MAXCHAR; i++)
        {
            Random rnd = new Random();
            sb.Append(charset[rnd.Next(charset.Length)]);
        }

        for(var i = 0; i < MAXNUM; i++)
        {
            Random rnd = new Random();
            sb.Append(rnd.Next(0,9));
        }

        return this._name = sb.ToString();
    }
}