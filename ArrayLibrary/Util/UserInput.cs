using System;

namespace ArrayLibrary.Util
{
    public class UserInput
    {
        private const int MIN_NATURAL_NUMBER = 1;
        private const string MSG_ERROR_INPUT_INTEGER_NUMBER = "Error! Data is not integer!";
        private const string MSG_ERROR_INPUT_NATURAL_NUMBER = "Error! Data is not natural number!";
        private const string MSG_GET_SIZE_ARRAY = "Enter size array";
        private const string MSG_GET_COLS_ARRAY = "Enter cols array";
        private const string MSG_GET_ROWS_ARRAY = "Enter rows array";
        private const string MSG_GET_MIN_NUMBER_TO_INIT = "Enter min number to initialize";
        private const string MSG_GET_MAX_NUMBER_TO_INIT = "Enter max number to initialize";

        private static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);

                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(MSG_ERROR_INPUT_INTEGER_NUMBER);
                }
            }
        }

        private static bool IsNaturalNumber(int number)
        {
            return number >= MIN_NATURAL_NUMBER;
        }

        private static int GetNaturalNumber(string msg)
        {
            while (true)
            {
                int number = GetNumber(msg);

                if (IsNaturalNumber(number))
                {
                    return number;
                }

                Console.WriteLine(MSG_ERROR_INPUT_NATURAL_NUMBER);
            }
        }

        private static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private static int InitNumberRandom(int min, int max)
        {
            if (min > max)
            {
                Swap(ref min, ref max);
            }

            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private static void InitArrayRandom(int min, int max, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = InitNumberRandom(min, max);
            }
        }

        public static int[] GetArrayInitRandom()
        {
            int size = GetNaturalNumber(MSG_GET_SIZE_ARRAY + ": ");
            Console.WriteLine();
            int min = GetNumber(MSG_GET_MIN_NUMBER_TO_INIT + ": ");
            int max = GetNumber(MSG_GET_MAX_NUMBER_TO_INIT + ": ");
            int[] array = new int[size];
            InitArrayRandom(min, max, array);
            return array;
        }

        private static int[] GetArrayInitRandom(int min, int max, int size)
        {
            int[] array = new int[size];
            InitArrayRandom(min, max, array);
            return array;
        }

        public static int[][] GetMatrixInitRandom()
        {
            int cols = GetNaturalNumber(MSG_GET_COLS_ARRAY + ": ");
            int rows = GetNaturalNumber(MSG_GET_ROWS_ARRAY + ": ");
            Console.WriteLine();
            int min = GetNumber(MSG_GET_MIN_NUMBER_TO_INIT + ": ");
            int max = GetNumber(MSG_GET_MAX_NUMBER_TO_INIT + ": ");
            int[][] array = new int[cols][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetArrayInitRandom(min, max, rows);
            }

            return array;
        }
    }
}