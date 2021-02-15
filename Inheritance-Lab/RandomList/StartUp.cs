using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList list = new RandomList();
            
            while (list.Count > 0)
            {
                Console.WriteLine(list.GetRandomElement());
            }
        }
    }
}
