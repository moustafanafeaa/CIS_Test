using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public delegate int MathOperation(int n1, int n2);

    public class MathOperator
    {
        public static int Addition(int a, int b) {  return a + b; }
        public static int subtraction(int a, int b) { return a - b; }
        public static int multiplication(int a, int b) { return a * b; }
        public static int division(int a, int b)
        {

            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
        }

    }
}
