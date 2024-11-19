using System.Linq;

public class Number
{
    public static int DigitalRoot(long n)
    {
        while (n > 9)
        {
            n = n.ToString().Sum(c => c - '0');
        }
        return (int)n;
    }
}