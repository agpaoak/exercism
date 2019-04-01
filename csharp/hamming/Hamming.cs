using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }
        else if (String.IsNullOrEmpty(firstStrand) || String.IsNullOrEmpty(secondStrand)
|| firstStrand.Equals(secondStrand))
        {
            return 0;
        }
        else
        {
            int diffCount = 0;
            char[] firstStrandArr = firstStrand.ToCharArray();
            char[] secondStrandArr = secondStrand.ToCharArray();

            for(var i=0; i < firstStrandArr.Length -1 ; i++)
            {
                if(firstStrandArr[i].Equals(secondStrandArr[i]))
                {
                    diffCount += 1;
                }
            }

            return firstStrandArr.Length - diffCount;
        }
    }
}