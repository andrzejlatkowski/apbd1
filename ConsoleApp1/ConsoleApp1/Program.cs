namespace ConsoleApp1;

public static class Lab1
{
    public static double Average(int[] x)
    {
        double sum = 0;
        foreach (var t in x)
        {
            sum += t;
        }


        double res = sum / x.Length;
        return res;
    }

    public static int Max(int[] x)
    {
        int res = x[0];
        for (int j = 1; j < x.Length; j++)
        {
            if (x[j] > res)
            {
                res = x[j];
            }
        }

        return res;
    }
}


internal abstract class Program
{
    private static void Main()
    {
        int[] numbers = [5, 1, 2, 13, 3, 4];
        double res = Lab1.Average(numbers);
        Console.WriteLine(res);

        int max = Lab1.Max(numbers);
        Console.WriteLine(max);
    }
}