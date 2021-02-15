using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();

            string[] inputNumbers = Console.ReadLine().Split();
            string[] inputURL = Console.ReadLine().Split();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                smartphone.Call(inputNumbers[i]);
            }

            for (int i = 0; i < inputURL.Length; i++)
            {
                smartphone.Browse(inputURL[i]);
            }
        }
    }
}
