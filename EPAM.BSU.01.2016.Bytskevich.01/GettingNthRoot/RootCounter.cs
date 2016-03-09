using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingNthRoot
{
    public class RootCounter
    {
        public int num;
        public double GetRoot(double number, int degree, double requiredAccuracy)
        {
            double result = number;
            double accuracy = 1;
            double currentValue = 0;   num = 0;
            while (accuracy > requiredAccuracy)
            {
                currentValue = ((degree - 1) * result + number / Exponentation(result, degree - 1)) / degree;
                accuracy = Math.Abs(result - currentValue);
                result = currentValue;  num++;
            }
            return result;
        }

        private double Exponentation(double x, int n)
        {
            double result = x;
            for (int i = 1; i < n; i++)
                result = result * x;
            return result;
        }

    }
}
