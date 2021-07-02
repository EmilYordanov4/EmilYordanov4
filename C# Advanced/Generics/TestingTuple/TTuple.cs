using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTuple
{
    public class TTuple<T,U>
    {
        public T ItemOne { get; set; }
        public U ItemTwo { get; set; }

       // public V ItemThree { get; set; }

        public TTuple(T firstItem , U secondItem)//, V thirdItem)
        {
            ItemOne = firstItem;
            ItemTwo = secondItem;
          //  ItemThree = thirdItem;
        }

        public override string ToString()
        {
            return $"{ItemOne} -> {ItemTwo}";
            //return $"{ItemOne} -> {ItemTwo} -> {ItemThree}";
        }

    }
}
