using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string result = string.Concat(n.ToString().Select(c => 
            (int.Parse(c.ToString()) * int.Parse(c.ToString())).ToString()));
        return int.Parse(result);
    }
}