using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number to calculate factorial for");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            Console.WriteLine("Result is {0}", result);
            Console.ReadLine();
        }
    }
}
