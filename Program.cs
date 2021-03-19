using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int add, sub, mul, div;
            Console.WriteLine("enter a value");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            int b = int.Parse(Console.ReadLine());
            add = a + b;
            sub = a - b;
            mul = a * b;
            div=a/b;
            Console.WriteLine("the result is:" + add);
            Console.WriteLine("the result is:" + sub);
            Console.WriteLine("the result is:" + mul);
            Console.WriteLine("the result is:" + div);
            Console.ReadLine();


        }
    }
}
