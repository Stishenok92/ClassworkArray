namespace ArrayLibrary.View
{
    public class Printer
    {
        private static string MSG_ARRAY_EMPTY = "Array is empty";
        private static string MSG_ARRAY_NULL = "Array is null";

        private static bool IsNullOrEmptyArray(int[] array, out string msg)
        {
            bool flag = true;

            if (array == null)
            {
                msg = MSG_ARRAY_NULL;
            }
            else if (array.Length == 0)
            {
                msg = MSG_ARRAY_EMPTY;
            }
            else
            {
                msg = "";
                flag = false;
            }

            return flag;
        }

        public static string ShowArray(int[] array)
        {
            if (!IsNullOrEmptyArray(array, out string msg))
            {
                foreach (int number in array)
                {
                    msg += number + " ";
                }
            }

            return msg;
        }

        public static string ShowMatrix(int[][] array)
        {
            if (!IsNullOrEmptyArray(array[0], out string msg))
            {
                foreach (int[] rows in array)
                {
                    msg += ShowArray(rows) + "\n";
                }
            }

            return msg;
        }
    }
}