using System;
using System.Linq;

public class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        return arr.Where((value, index) => index % 2 == 0).ToArray();
    }
}