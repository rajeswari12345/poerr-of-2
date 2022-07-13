// See https://aka.ms/new-console-template for more information
using System;
class powerof2
{
    static bool PowerOfTwo(int n)
    {
        return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
            == (int)(Math.Floor(Math.Log(n) / Math.Log(2))));

    }
    public static void main()
    {
        if (PowerOfTwo(31))
            Console.WriteLine("yes");
        else
            Console.WriteLine("No");
        if (PowerOfTwo(64))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");


    }

}