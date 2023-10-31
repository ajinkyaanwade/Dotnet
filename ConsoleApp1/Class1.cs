using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public int add(int a,int b)
        {
            Console.WriteLine("The addition of two numbers is");
            return a + b;
        }
        public int product(int a,int b)
        {
            Console.WriteLine("The multiplication of two numbers is");
            return a * b;
        }
    }
}