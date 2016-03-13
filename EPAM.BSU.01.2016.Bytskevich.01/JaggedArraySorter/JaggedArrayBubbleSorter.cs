using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public static class JaggedArrayBubbleSorter
    {
        struct jaggedArrayLine
        {
            public int parameter;
            public int[] lineAddress;
        }

        public static void Sort(int[][] source, bool inIncreasingOrder, Func<int[], int> wayOfGettingLineParameter)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            else if (wayOfGettingLineParameter == null)
                throw new ArgumentNullException("wayOfGettingLineParameter");
            else
            {
                jaggedArrayLine[] jaggedArrLines = new jaggedArrayLine[source.Length];
                for (int i = 0; i < source.Length; i++)
                {
                    jaggedArrLines[i].parameter = wayOfGettingLineParameter(source[i]);
                    jaggedArrLines[i].lineAddress = source[i];
                }
                bool thereWerePermutations = true;
                for (int i = 0; (i < source.Length - 1) && thereWerePermutations; i++)
                {
                    thereWerePermutations = false;
                    for (int j = 0; j < source.Length - i - 1; j++)
                    {
                        if ((inIncreasingOrder && jaggedArrLines[j].parameter > jaggedArrLines[j + 1].parameter) || (!inIncreasingOrder && jaggedArrLines[j].parameter < jaggedArrLines[j + 1].parameter))
                        {
                            Swap(ref jaggedArrLines[j], ref jaggedArrLines[j + 1]);
                            thereWerePermutations = true;
                        }
                    }
                }
                for (int i = 0; i < source.Length; i++)
                    source[i] = jaggedArrLines[i].lineAddress;
            }
        }

        private static void Swap (ref jaggedArrayLine first, ref jaggedArrayLine second)
        {
            jaggedArrayLine temp;
            temp = first;
            first = second;
            second = temp;
        }       

    }
}
