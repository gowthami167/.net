using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                if (y==1)
                {
                    return;

                }
                Console.Write("Enter the first number");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("TheResultis:"z);
            }catch (Exception ex)
            {
                Console.Write("ex.Message");
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }
}
