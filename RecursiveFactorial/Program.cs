using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive: The result is {0}", Factorial(5));
            Console.WriteLine("Facternary: The result is {0}", Facternary(5));
        }

        private static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;   //we're done
            }
            else
            {
                return n * Factorial(n - 1);    // keep on truckurring!
            }
        }

        /**
         * A more efficient way to write the Factorial method using the ternary opearator is given below.
         * In all cases, but 1, the value of n is non-zero so it is more efficient to evaluate the most frequent case first.
         * We should also validate the input to ensure n is a member of the Natural numbers i.e. a positive whole number including zero
         */
        private static int Facternary(int n)
        {
            return n != 0 ? n * Facternary(n - 1) : 1;
        }
    }
}
