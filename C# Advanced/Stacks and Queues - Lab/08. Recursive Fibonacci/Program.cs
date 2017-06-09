using System;

class RecursiveFibonacci
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] f = new long[51];

        for(int i = 0; i < 51; i++)
        {
            f[i] = -1;
        }

        Console.WriteLine(Fib(n, f));
    }

    public static long Fib(int n, long[] f)
    {
        if(n <= 1)
        {
            return n;
        }
        else if (f[n] != -1)
        {
            return f[n];
        }

        f[n] = Fib(n - 1, f) + Fib(n - 2, f);
        return f[n];
    }    
}