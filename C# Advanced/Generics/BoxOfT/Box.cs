using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> BoxList { get; set; }
        public int Count { get => BoxList.Count; }

        public Box()
        {
            BoxList = new List<T>();
        }
        public void Add(T element)
        {
            BoxList.Add(element);
        }
        public T Remove()
        {
            var output = BoxList.LastOrDefault();
            BoxList.RemoveAt(BoxList.Count - 1);
            return output;
        }
    }
}
