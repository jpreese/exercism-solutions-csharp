using System;
using System.Collections.Generic;
using System.Linq;

public class DNA
{
    public IDictionary<char, int> NucleotideCounts;

    public DNA(string sequence)
    {
        NucleotideCounts = new Dictionary<char, int>
        {
            {'A', 0 },
            {'T', 0 },
            {'C', 0 },
            {'G', 0 }
        };

        foreach(var key in NucleotideCounts.Keys.ToList())
        {
            NucleotideCounts[key] = sequence.Count(s => s == key);
        }
    }

    public int Count(char nucleotide)
    {
        if(NucleotideCounts.ContainsKey(nucleotide) == false)
        {
            throw new InvalidNucleotideException();
        }

        return NucleotideCounts[nucleotide];
    }
}

public class InvalidNucleotideException : Exception { }
