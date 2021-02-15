using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            for (int i = 1; i <= a; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
