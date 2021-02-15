using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public Random randomGenerator { get; set; }

        public RandomList()
        {
            randomGenerator = new Random();
        }
        
        public string GetRandomElement()
        {
            int index = randomGenerator.Next(0, this.Count - 1);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
