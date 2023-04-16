using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int y = Convert.ToInt32(Console.ReadLine());
            Clac(x, y);
        }
        private static void Clac(int x,int y)
        {
            double result = Math.Sqrt(Math.Abs(x)) + Math.Pow(y, 2);
            Console.WriteLine("The Result is : " + result);
        }
    }
}
