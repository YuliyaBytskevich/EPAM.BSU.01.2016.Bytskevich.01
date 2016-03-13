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
            if (number <= 0)
                throw new ArgumentException("First argument (number) must be positive");
            else if (requiredAccuracy < 0)
                throw new ArgumentException("Third argument (required accuracy) must not be negative");
            bool degreeIsNegative = false;
            if (degree < 0)
            {
                degreeIsNegative = true;
                degree = -degree;
            }
            else if (degree == 0)
                throw new ArgumentException("Second argument (degree) must not be 0");
            double result = number;
            double accuracy = 1;
            double currentValue = 0;  
            while (accuracy >= requiredAccuracy)
            {
                currentValue = ((degree - 1) * result + number / Math.Pow(result, degree - 1)) / degree;
                accuracy = Math.Abs(result - currentValue);
                result = currentValue; 
            }
            if (!degreeIsNegative)
                return result;
            else
                return 1d / result;
        }

    }
}
