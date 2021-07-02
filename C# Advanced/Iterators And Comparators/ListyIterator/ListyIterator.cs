using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIteratorProblem
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> ourList;
        private int Count => ourList.Count;
        private int currentIndex;
        public ListyIterator()
        {
            this.ourList = new List<T>();
            currentIndex = 0;
        }
        public void Create(params T[] info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                ourList.Add(info[i]);
            }
        }
        public bool Move()
        {
            bool itMoved = false;
            if (HasNext())
            {
                currentIndex++;
                itMoved = true;
            }

            return itMoved;
        }

        public bool HasNext()
        {
            bool hasNextElement = false;
            if (currentIndex < ourList.Count - 1)
            {
                hasNextElement = true;
            }
            return hasNextElement;
        }

        public void Print()
        {
            if (ourList.Count <= currentIndex)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(ourList[currentIndex]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < ourList.Count; i++)
            {
                yield return ourList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
