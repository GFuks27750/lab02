class Program
{
    public static double Average(int[] array)
    {
           double average =  Queryable.Average(array.AsQueryable());
           return average;
    }
}
