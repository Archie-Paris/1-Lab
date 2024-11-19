using System;
using System.Linq;

public class Kata
{
    public static string ExpandedForm(long num)
    {
        var digits = num.ToString()
        .Select((digit, index) => 
                
        long.Parse(digit.ToString()) * (long)Math.Pow(10, num.ToString().Length - index - 1))
        .Where(value => value > 0);
      
        return string.Join(" + ", digits);
    }
}