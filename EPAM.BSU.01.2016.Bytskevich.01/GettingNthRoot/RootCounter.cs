using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingNthRoot
{
    public static class RootCounter
    {
        public static double GetRoot(double number, int degree, double requiredAccuracy)
        {
            if (number < 0)
                throw new ArgumentException("First argument (number) must be positive");
            else if (requiredAccuracy < 0)
                throw new ArgumentException("Third argument (required accuracy) must be positive");
            double result = number;
            double accuracy = 1;
            double currentValue = 0;  
            while (accuracy >= requiredAccuracy)
            {
                currentValue = ((degree - 1) * result + number / Math.Pow(result, degree - 1)) / degree;
                accuracy = Math.Abs(result - currentValue);
                result = currentValue; 
            }
            return result;
        }

    }
}
