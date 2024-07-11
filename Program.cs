using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {



        public static void Main(String[] args)
        {

            int myNumber;
            Console.WriteLine("Enter the number for Factorial");

            myNumber = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = myNumber; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine("Factorial of number is :" + result);


        }
    }
}
