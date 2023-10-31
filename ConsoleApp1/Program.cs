using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine("Enter the two numbers to add");
            int A=Convert.ToInt32(Console.ReadLine());
            int B=Convert.ToInt32(Console.ReadLine());
            int addition=c1.add(A, B);
            Console.WriteLine(addition);
            Console.WriteLine("Enter the two numbers for product");
            int C=Convert.ToInt32(Console.ReadLine());
            int D=Convert.ToInt32(Console.ReadLine());
            int product=c1.product(C, D);
            Console.WriteLine(product);

        }
    }
}
