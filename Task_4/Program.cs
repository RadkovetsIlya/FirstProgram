internal class Program
{
    private static void Main(string[] args)
    {
        int a = 12;
        int b = 3;
        int c = 8;
        int d = 67;
        int e = 34;

        int max = a;

        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        if (d > max)
        {
            max = d;
        }
        if (e > max)
        {
            max = e;
        }
        Console.WriteLine (max);
    }
}

