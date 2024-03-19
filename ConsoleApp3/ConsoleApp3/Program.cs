class Program
{
    public static double Max(int[] array)
    {
        double max = Queryable.Max(array.AsQueryable());
        return max; 
    }

    static void Main()
    {
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(Max(arr));
    }
}