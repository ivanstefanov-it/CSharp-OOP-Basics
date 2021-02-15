using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : List<string>
    {
        public void Push(string element)
        {
            Add(element);
        }

        public string Pop()
        {
            string element = GetLastEmelent();
            RemoveAt(Count - 1);
            return element;
        }

        public string Peek()
        {
            return GetLastEmelent();
        }

        public bool IsEmpty()
        {
            return Count < 1;
        }

        private string GetLastEmelent()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return this.Last();
           

        }
    }
}
