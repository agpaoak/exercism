using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        //
        Regex unacceptedChars = new Regex("[^ACGT]");

        if (unacceptedChars.IsMatch(sequence))
        {
            throw new ArgumentException();
        }
        else
        {
            return new Dictionary<char, int>
            {
                ['A'] = sequence.Count(a => a == 'A'),
                ['C'] = sequence.Count(c => c == 'C'),
                ['G'] = sequence.Count(g => g == 'G'),
                ['T'] = sequence.Count(t => t == 'T')
            };
        }
    }
}