using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class App
    {
        public static bool CalculatingFibonacci(int valueUserFibonacci)
        {
            int firstValue = 0;
            int secondValue = 1;
            int valueFibonacci = 0;

            while(valueFibonacci < valueUserFibonacci)
            {
                valueFibonacci = firstValue + secondValue;

                firstValue = secondValue;
                secondValue = valueFibonacci;
            }

            if (valueFibonacci != valueUserFibonacci)
                return false;

            return true;
        }
    }
}
