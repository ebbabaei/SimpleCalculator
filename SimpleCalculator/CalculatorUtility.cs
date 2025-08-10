using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorUtility
    {
        public int Sum(int a, int b)
        {
            Console.WriteLine($"[Sum] a={a}, b={b}");
            checked { return a + b; } // برای جلوگیری از سرریز
        }

        public int Multiply(int a, int b)
        {
            Console.WriteLine($"[Multiply] a={a}, b={b}");
            checked { return a * b; } // جلوگیری از سرریز
        }

        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }


        /// <summary>
        /// subtrac
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Subtract(int a, int b)
        {
            Console.WriteLine($"[Subtract] a={a}, b={b}");
            checked { return a - b; }
        }

    }
}
