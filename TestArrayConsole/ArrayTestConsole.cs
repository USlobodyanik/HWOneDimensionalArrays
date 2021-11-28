using OneDimensionalArrays;
using System;

namespace HomeWorkLessonArray
{
    class ArrayTestConsole
    {
        static void Main(string[] args)
        {
            int[] array = OneDimensionalArraysLibrary.FillingArray(5,-8,20);
            Console.WriteLine("Input array: ");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"{Environment.NewLine}Min = {OneDimensionalArraysLibrary.MinimumArrayValue(array)}" +
                $" / find Min whith index = {OneDimensionalArraysLibrary.MinimumArrayValueV2(array)}");
            Console.WriteLine($"{Environment.NewLine}Max = {OneDimensionalArraysLibrary.MaximumArrayValue(array)}" +
                $" / find Max whith index = {OneDimensionalArraysLibrary.MaximumArrayValueV2(array)}");

            array = OneDimensionalArraysLibrary.FillingArray(5, -8, 20);
            Console.WriteLine($"{Environment.NewLine}Input array: ");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"{Environment.NewLine}Min value in array indexed = " +
                $"{OneDimensionalArraysLibrary.MinimumArrayValueIndex(array)}");
            Console.WriteLine($"{Environment.NewLine}Max value in array indexed = " +
                $"{OneDimensionalArraysLibrary.MaximumArrayValueIndex(array)}");

            Console.WriteLine($"{Environment.NewLine}Input array: ");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\t\tSum value odd index array = {OneDimensionalArraysLibrary.SumOddIndexArray(array)}");

            array = OneDimensionalArraysLibrary.FillingArray(5, -20, 20);
            Console.Write($"{Environment.NewLine}Input array: \t\t");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            int[] reverseArray = OneDimensionalArraysLibrary.ReverseArray(array);
            Console.Write($"{Environment.NewLine}Reverse array : \t");
            foreach (int item in reverseArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine($"{Environment.NewLine}Input array:");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\tSum odd numbers in array = {OneDimensionalArraysLibrary.SumOddValueInArray(array)}");

            array = OneDimensionalArraysLibrary.FillingArray(5, -10, 10);
            Console.Write($"{Environment.NewLine}Input array:\t\t");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            int[] halfReverseArray = OneDimensionalArraysLibrary.HalfReverseArray(array);

            Console.Write($"{Environment.NewLine}Half reverse array :\t");
            foreach (int item in halfReverseArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            array = OneDimensionalArraysLibrary.FillingArray(5, -5, 5);
            Console.Write($"{Environment.NewLine}Input array:\t\t\t");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            int[] bubbleSortArray = OneDimensionalArraysLibrary.BubbleSortAsc(array);
            Console.Write($"{Environment.NewLine}Bubble sort array (ascending):\t");

            foreach (int item in bubbleSortArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.Write($"{Environment.NewLine}Input array:\t\t\t\t");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            int[] selectionSortArray = OneDimensionalArraysLibrary.SelectionSortDesc(array);
            Console.Write($"{Environment.NewLine}Selection sort array (descending):\t");

            foreach (int item in selectionSortArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
