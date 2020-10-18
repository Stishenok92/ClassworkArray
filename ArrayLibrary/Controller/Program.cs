using static ArrayLibrary.Model.BusinessLogic;
using static ArrayLibrary.View.Printer;
using static ArrayLibrary.Util.UserInput;
using System;

namespace Program.Controller
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array\n");
            
            Console.WriteLine("Task 1\nFind mul of even numbers in array\n");
            int[] array1 = GetArrayInitRandom();
            Console.WriteLine();
            Console.WriteLine(ShowArray(array1));
            Console.WriteLine();
            Console.WriteLine("Multiplication: " + CalculateMulNumbersWithEvenIndex(array1));
            Console.WriteLine();
            
            Console.WriteLine("Task 2\nFind sum of array numbers located between first and last index with number zero\n");
            int[] array2 = GetArrayInitRandom();
            Console.WriteLine();
            Console.WriteLine(ShowArray(array2));
            Console.WriteLine();
            Console.WriteLine("Sum: " + CalculateSumBetweenFirstAndLastIndexWithNumberZero(array2));
            Console.WriteLine();
            
            Console.WriteLine("Task 3\nFind number of line containing longest series of identical numbers\n");
            int[][] matrix = GetMatrixInitRandom();
            Console.WriteLine();
            Console.WriteLine(ShowMatrix(matrix));
            Console.WriteLine("Number line: " + FindIndexRowMaxSeriesNumber(matrix));
        }
    }
}