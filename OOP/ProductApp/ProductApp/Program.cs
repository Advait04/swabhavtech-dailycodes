using ProductApp.Model;
using System;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            casestudy1();

            casestudy2();

            Console.ReadLine();
        }

        private static void casestudy1()
        {
            Product p1 = new Product(101, "headfirst jawa", 500);
            PrintDetails(p1);
            Console.WriteLine();
            Product p2 = new Product(102, "headfirst c#", 600, 10);
            PrintDetails(p2);
        }

        private static void casestudy2()
        {
            Console.WriteLine();
            Console.WriteLine("Casestudy 2");
            Console.WriteLine();
            Product p3 = new Product(103, "headfirst jawa", 500);
            Console.WriteLine(p3.GetInstanceCount());
            Product p4 = new Product(104, "headfirst jawa", 500);
            Console.WriteLine(p4.GetInstanceCount());
            Product p5 = new Product(105, "headfirst jawa", 500);
            Console.WriteLine(p5.GetInstanceCount());
        }

        static void PrintDetails(Product p1)
        {
            Console.WriteLine("product id: " + p1.GetProductId());
            Console.WriteLine("product name: " + p1.GetProductName());
            Console.WriteLine("product price: " + p1.GetProductPrice());
            Console.WriteLine("product discount percentage: " + p1.GetProductDiscountPercent());
            Console.WriteLine("final price of project: " + p1.GetFinalPrice());
        }

    }
}
