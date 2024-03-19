class Program
{
    
    static double Average(int[] array)
    {
           double average =  Queryable.Average(array.AsQueryable());
           return average;
    }

    static void Main()
    {
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(Average(arr));
    }
    
}
