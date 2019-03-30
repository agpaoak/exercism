using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return this.scores;  
    }

    public int Latest()
    {
        return scores.Last<int>();
    }

    public int PersonalBest()
    {
        return scores.Max<int>();
    }

    public List<int> PersonalTopThree()
    {
        List<int> temp = new List<int>(scores);
        temp.Sort();
        temp.Reverse();


        if (temp.Count < 3)
        {
            return temp;
        }

        return new List<int>(temp.GetRange(0, 3));
    }
}