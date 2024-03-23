namespace ConsoleApp1;

public static class Lab1
{
    public static double Average(int[] x)
    {
        return x.Average();
    }

    public static int Max(int[] x)
    {
        return x.Max();
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