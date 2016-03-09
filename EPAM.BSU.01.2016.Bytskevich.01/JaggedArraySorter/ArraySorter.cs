using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public class ArraySorter
    {
        struct line
        {
            public int parameter;
            public int[] lineAddress;
        }
        public delegate int DefineSortingParameter(int[] line);

        private void SortWithCommonAlgorithm(int[][] source, bool isIncreasing, DefineSortingParameter getCurrentParameter)
        {
            line[] lines = new line[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                lines[i].parameter = getCurrentParameter(source[i]);
                lines[i].lineAddress = source[i];
            }
            bool thereWerePermutations = true;
            line temp;
            for (int i = 0; (i < source.Length - 1) && thereWerePermutations; i++)
            {
                thereWerePermutations = false;
                for (int j = 0; j < source.Length - i - 1; j++)
                {
                    if ((isIncreasing && lines[j].parameter > lines[j + 1].parameter) || (!isIncreasing && lines[j].parameter < lines[j + 1].parameter))
                    {
                        temp = lines[j];
                        lines[j] = lines[j + 1];
                        lines[j + 1] = temp;
                        thereWerePermutations = true;
                    }
                }
            }
            for (int i = 0; i < source.Length; i++)
                source[i] = lines[i].lineAddress;
        }

        public void SortByIncreaseOfLineSums(int[][] source)
        {
            SortWithCommonAlgorithm(source, true, GetLineSum);
        }

        public void SortByDecreaseOfLineSums(int[][] source)
        {
            SortWithCommonAlgorithm(source, false, GetLineSum);
        }

        public void SortByIncreaseOfMaxElements(int[][] source)
        {
            SortWithCommonAlgorithm(source, true, GetMaxElement);
        }

        public void SortByDecreaseOfMaxElements(int[][] source)
        {
            SortWithCommonAlgorithm(source, false, GetMaxElement);
        }

        public void SortByIncreaseOfMinElements(int[][] source)
        {
            SortWithCommonAlgorithm(source, true, GetMinElement);
        }

        public void SortByDecreaseOfMinElements(int[][] source)
        {
            SortWithCommonAlgorithm(source, false, GetMinElement);
        }

        private int GetLineSum(int[] line)
        {
            int result = 0;
            for (int i = 0; i < line.Length; i++)
                result += line[i];
            return result;
        }

        private int GetMaxElement(int[] line)
        {
            int result = 0;
            for (int i = 0; i < line.Length; i++)
                if (line[i] > result)
                result = line[i];
            return result;
        }

        private int GetMinElement(int[] line)
        {
            int result = Int32.MaxValue;
            for (int i = 0; i < line.Length; i++)
                if (line[i] < result)
                    result = line[i];
            return result;
        }


    }
}
