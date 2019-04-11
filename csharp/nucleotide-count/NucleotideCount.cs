using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> result = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach(var dna in sequence.ToCharArray())
        {
            if (result.ContainsKey(dna))
            {
                result[dna] += 1;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        return result;
    }
}