using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("enter first number:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("enter second number:");
                    int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("the result is:" + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.Write(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.Write("input must be numeric");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.WriteLine("end of program");
            Console.ReadLine();
        }
    }
}




        

