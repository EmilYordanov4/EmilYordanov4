using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable
    {
        public T Value { get; set; }
        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            Type type = typeof(T);
            return $"{type.FullName}: {Value}";
        }
    }
}
