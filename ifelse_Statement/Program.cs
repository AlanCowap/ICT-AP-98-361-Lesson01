using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIfElse(1);
            TestIfElse(11);
            TestIfElse(21);
            TestIfElse(31);
            //TestIfElse("oops");   // Compiler complains, TestIfElse(int) takes an int datatype as argument, not a String.
        }

        private static void TestIfElse(int n)
        {
            if(n < 10)
            {
                Console.WriteLine("n is less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }
            else if (n < 30)
            {
                Console.WriteLine("n is less than 30");
            }
            else
            {
                Console.WriteLine("n is greater than or equal to 30");
            }

        }

    }
}
