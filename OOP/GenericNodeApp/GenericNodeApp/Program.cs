using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<String> n1 = new Node<String>();
            n1.Data = "Mumbai";

            Node<String> n2 = new Node<String>();
            n2.Data = "Pune";

            Node<String> n3 = new Node<String>();
            n3.Data = "Delhi";

            n1.Next = n2;
            n2.Next = n3;
            PrintDetails(n1);
            PrintDetails(n2);

            Console.ReadKey();
        }
        public static void PrintDetails(Node<string> node)
        {
            var newNode = node;
            Console.WriteLine("\nNodes:");
            while (newNode != null)
            {

                PrintNode(newNode);
                newNode = newNode.Next;
            }
        }
        private static void PrintNode(Node<string> node)
        {
            Console.WriteLine("Data: {0}", node.Data);
        }
    }
}

