using System;
using System.Collections.Generic;
using ConsoleApp40.Entities;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for(int i =1; i<=n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                int price = int.Parse(Console.ReadLine());

                if(ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                else if(ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacturedate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine(  );
            Console.WriteLine("PRICE TAGS");
            foreach(Product pro in list)
            {
                Console.WriteLine(pro);
            }


        }
    }
}
