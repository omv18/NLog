using System;
namespace NLogProjecct
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            AddNumbers add = new AddNumbers();
            Console.WriteLine("Result is : "+add.Sum(a,b));
        }
    }
}
