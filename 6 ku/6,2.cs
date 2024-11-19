using System;
using System.Linq;

public class Kata
{
    public static int Solve(string input)
    {
        string vowels = "aeiou";
        var consonantValues = input
            .Split(vowels.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(substring => substring.Sum(c => c - 'a' + 1));
        return consonantValues.Any() ? consonantValues.Max() : 0;
    }
}