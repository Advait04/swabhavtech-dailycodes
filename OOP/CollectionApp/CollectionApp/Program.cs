using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        public static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("Kid Toys", 500, 3));
            basket.Add("Hello Aurionpro");
            foreach (LineItem item in basket)
            {
                Console.WriteLine(item.productname);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Quantity);
                Console.WriteLine(item.TotalPrice());
            }
            Console.ReadLine();
        }

        public static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("shoes", 1000, 2));
            basket.Add(new LineItem("mobile", 15000, 1));
            basket.Add(new LineItem("Shiert", 400, 5));

            double FinalPrice = 0;
            foreach(LineItem item in basket)
            {
                Console.WriteLine("Product Name:" + item.productName);
                Console.WriteLine("product Price::" + item.Price);
                Console.WriteLine("Product Quantity:" + item.Quantity);
                Console.WriteLine("Product total Price:" +item.TotalPrice());
            }
            Console.WriteLine("FinalPrice:" + FinalPrice);

        }
    }
}
