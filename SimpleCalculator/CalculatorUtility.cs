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
            checked { return a + b; } // برای جلوگیری از سرریز
        }
    }
}
