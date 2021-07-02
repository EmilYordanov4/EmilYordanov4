using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    class Lake<T> : IEnumerable<T>
    {
        private List<T> frogPath;

        public Lake(T[] elements)
        {
            this.frogPath = new List<T>(elements.ToList());
        }
        public IEnumerator<T> GetEnumerator()
        {
            int count = frogPath.Count;
            for (int i = 0; i < count; i+= 2)
            {
                yield return frogPath[i];
            }

            if (frogPath.Count % 2 != 0)
            {
                count--;
            }
            for (int i = count - 1; i >= 0; i-=2)
            {
                yield return frogPath[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
