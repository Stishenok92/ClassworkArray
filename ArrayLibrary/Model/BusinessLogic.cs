using System;
using static ArrayLibrary.View.Printer;

namespace ArrayLibrary.Model
{
    public class BusinessLogic
    {
        private static int MIN_ARRAY_EVEN_INDEX = 2;

        private static bool IsNullOrEmpty(int[] array)
        {
            return array == null || array.Length == 0;
        }

        public static int CalculateMulNumbersWithEvenIndex(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return 0;
            }

            int mul = 1;

            for (int i = 0; i < array.Length; i += 2)
            {
                mul *= array[i];
            }

            return mul;
        }

        public static int CalculateSumBetweenFirstAndLastIndexWithNumberZero(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return 0;
            }

            int sum = 0;
            int firstIndex = FindFirstIndexWithZero(array);

            if (firstIndex != -1)
            {
                int lastIndex = FindLastIndexWithZero(array);

                if (firstIndex != lastIndex)
                {
                    sum = SumNumberWithArray(firstIndex, lastIndex, array);
                }
            }

            return sum;
        }

        private static int FindFirstIndexWithZero(int[] array)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static int FindLastIndexWithZero(int[] array)
        {
            int index = -1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static int SumNumberWithArray(int firstIndex, int lastIndex, int[] array)
        {
            int sum = 0;

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private static void SortMatrix(int[][] matrix)
        {
            foreach (int[] array in matrix)
            {
                SortArray(array);
            }
        }

        public static int FindIndexRowMaxSeriesNumber(int[][] array)
        {
            if (IsNullOrEmpty(array[0]))
            {
                return -1;
            }

            int[][] temp = array;
            SortMatrix(temp);
            Console.WriteLine(ShowMatrix(temp));

            int index = -1;
            int count = 0;
            int countMax = 1;

            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp[i].Length - 1; j++)
                {
                    if (temp[i][j] == temp[i][j + 1])
                    {
                        count++;

                        if (count > countMax)
                        {
                            countMax = count;
                            index = i;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }

            return index;
        }
    }
}