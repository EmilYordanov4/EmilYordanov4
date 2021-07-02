using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStackProblem
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> ourStack;
        private int count => ourStack.Count;

        public CustomStack()
        {
            this.ourStack = new List<T>();
        }
        public void Push(T[] elementsToAdd)
        {
            for (int i = 0; i < elementsToAdd.Length; i++)
            {
                ourStack.Add(elementsToAdd[i]);
            }
        }
        public void Pop()
        {
            if (ourStack.Count > 0)
            {
                ourStack.RemoveAt(count - 1);
            }
            else
            {
                Console.WriteLine($"No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = ourStack.Count - 1; i >= 0; i--)
            {
                yield return ourStack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
