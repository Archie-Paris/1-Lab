using System;

public class Kata
{
    public static int Enough(int cap, int on, int wait)
    {
        int totalPeople = on + wait;

        return totalPeople > cap ? totalPeople - cap : 0;
    }
}