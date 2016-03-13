using System;
using GettingNthRoot;

namespace TestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            int n;
            double accuracy;
            while(true)
              {
                  Console.Write("Please, enter a number (X) to be raised to the power N (use ',' as a divider): ");
                  if (Double.TryParse(Console.ReadLine(), out x))
                  {
                      Console.Write("Please, enter deegree (N): ");
                      if (Int32.TryParse(Console.ReadLine(), out n))
                      {
                          double y = Math.Pow(x, n);
                          Console.WriteLine("Y = Math.Pow(X, N) = " + y);
                          Console.Write("Well, trying to get root :)\nPlease, enter accuracy order to count root (use ',' as a divider): ");
                          if (Double.TryParse(Console.ReadLine(), out accuracy))
                          {
                              Console.WriteLine(n + "-th root of Y seems to be like " + RootCounter.GetRoot(y, n, -1) + "\n\n");
                          }
                      }
                  }
              }  
        }

    }
}
