using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp40.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customsfee)
            : base(name, price)
        {
            CustomsFee = customsfee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string ToString()
        {
            return Name + " $" + TotalPrice() + " (Customs fee: $" + CustomsFee + ") ";
        }
    }
}
