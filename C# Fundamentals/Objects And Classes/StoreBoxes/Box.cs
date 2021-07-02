using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal PriceForABox 
        {
            get;
            set;
        }

        public decimal PricePerItem { get; set; }
    }
}
