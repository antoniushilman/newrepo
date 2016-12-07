using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number: ");
            string a = Console.ReadLine();

            Console.WriteLine("Input second number");
            string b = Console.ReadLine();

            double a_value, b_value;

            if (double.TryParse(a, out a_value) && double.TryParse(b, out b_value))
            {
                Console.WriteLine("Result: {0}", (a_value * b_value));
            }
            else
            {
                Console.WriteLine("Not an integer!!");
            }
        }
    }
}
