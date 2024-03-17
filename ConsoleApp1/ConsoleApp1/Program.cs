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
}

internal abstract class Program
{
    private static void Main()
    {
        int[] numbers = [1, 2, 3, 4];
        double res = Lab1.Average(numbers);
        Console.WriteLine(res);
    }
}