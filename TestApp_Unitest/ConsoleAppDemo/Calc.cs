using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Calc
    {
        public int Sum(List<int> arrayNumbers) {
            // return arrayNumbers.Sum() + 1; // UnitTest Not run.
            return arrayNumbers.Sum();
        }
        public int Sum2Numbers(int number1, int number2) {
            return number1 + number2;
        }
        public int Divide(int number1, int number2) {
            if (number2 > 0)
            {
                return number1 / number2;
            }
            return 0;
        }
    }
}
