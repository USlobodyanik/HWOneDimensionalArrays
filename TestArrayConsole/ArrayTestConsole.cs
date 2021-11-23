using OneDimensionalArrays;
using System;

namespace HomeWorkLessonArray
{
    class ArrayTestConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Min = {OneDimensionalArraysLibrary.MinimumArrayValue(5, -8, 20)}");
            Console.WriteLine();
            Console.WriteLine($"Max = {OneDimensionalArraysLibrary.MaximumArrayValue(5, 0, 20)}");
            Console.WriteLine();

            (int minI, int[] arrayMin) = OneDimensionalArraysLibrary.MinimumArrayValueIndex(5, -8, 20);
            for (int i = 0; i < arrayMin.Length; i++)
            {
                Console.Write($"{arrayMin[i]} ");
            }
            Console.WriteLine($"\tMin value in array indexed = {minI}");
            Console.WriteLine();

            (int maxI, int[] arrayMax) = OneDimensionalArraysLibrary.MaximumArrayValueIndex(5, -8, 20);
            for (int i = 0; i < arrayMax.Length; i++)
            {
                Console.Write($"{arrayMax[i]} ");
            }
            Console.WriteLine($"\tMax value in array indexed = {maxI}");
            int[] reverseArray = OneDimensionalArraysLibrary.ReverseArray(5, 1, 5);
            Console.WriteLine();

            Console.Write("Reverse array : ");
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.Write($"{reverseArray[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"{Environment.NewLine}Sum odd numbers in array = {OneDimensionalArraysLibrary.SumOddValueInArray(5, 0, 20)}");
            (int[] debagArray, int[] halfReverseArray) = OneDimensionalArraysLibrary.HalfReverseArray(5, 1, 5);
            Console.WriteLine();

            Console.WriteLine("Half reverse array : ");
            for (int i = 0; i < halfReverseArray.Length; i++)
            {
                Console.WriteLine($"Input number{debagArray[i]} / reversed {halfReverseArray[i]} ");
            }
            Console.WriteLine();

            (int[] debagBubbleArray, int[] bubbleSortArray) = OneDimensionalArraysLibrary.BubbleSortAsc(5, 1, 5);
            Console.WriteLine("Sort (bubble) array/ascending): ");
            for (int i = 0; i < bubbleSortArray.Length; i++)
            {
                Console.WriteLine($"Input number{debagBubbleArray[i]} / sorted {bubbleSortArray[i]} ");
            }
            Console.WriteLine();

            (int[] debagSelectionArray, int[] selectionSortArray) = OneDimensionalArraysLibrary.SelectionSortDesc(5, 1, 5);
            Console.WriteLine("Sort (Selection) array/descending): ");
            for (int i = 0; i < selectionSortArray.Length; i++)
            {
                Console.WriteLine($"Input number{debagSelectionArray[i]} / sorted {selectionSortArray[i]} ");
            }

        }
    }
}
