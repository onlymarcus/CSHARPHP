using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp40.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedate) 
            : base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string ToString()
        {
            return Name + " (used) $" + Price + " (Manufacture date: " + ManufactureDate + ")";
        }
    }
}
