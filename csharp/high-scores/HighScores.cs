using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
<<<<<<< HEAD
    public List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
=======
    public HighScores(List<int> list)
    {
        throw new NotImplementedException();
>>>>>>> 2aaca39938f022a0e11ad838d87f208f196a5610
    }

    public List<int> Scores()
    {
<<<<<<< HEAD
        return this.scores;  
=======
        throw new NotImplementedException();
>>>>>>> 2aaca39938f022a0e11ad838d87f208f196a5610
    }

    public int Latest()
    {
<<<<<<< HEAD
        return scores.Last<int>();
=======
        throw new NotImplementedException();
>>>>>>> 2aaca39938f022a0e11ad838d87f208f196a5610
    }

    public int PersonalBest()
    {
<<<<<<< HEAD
        return scores.Max<int>();
=======
        throw new NotImplementedException();
>>>>>>> 2aaca39938f022a0e11ad838d87f208f196a5610
    }

    public List<int> PersonalTopThree()
    {
<<<<<<< HEAD
        List<int> temp = new List<int>(scores);
        temp.Sort();
        temp.Reverse();


        if (temp.Count < 3)
        {
            return temp;
        }

        return new List<int>(temp.GetRange(0, 3));
=======
        throw new NotImplementedException();
>>>>>>> 2aaca39938f022a0e11ad838d87f208f196a5610
    }
}