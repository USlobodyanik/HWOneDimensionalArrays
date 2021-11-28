using System;

namespace OneDimensionalArrays
{
    public class OneDimensionalArraysLibrary
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int MinimumArrayValue(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int MinimumArrayValueV2(int[] array)
        {
            return array[MinimumArrayValueIndex(array)];
        }

        public static int MinimumArrayValueIndex(int[] array)
        {
            int minI = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[0] > array[i])
                {
                    minI = i;
                }
            }

            return minI;
        }

        public static int MaximumArrayValue(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int MaximumArrayValueV2(int[] array)
        {
            return array[MaximumArrayValueIndex(array)];
        }

        public static int MaximumArrayValueIndex(int[] array)
        {
            int maxI = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[0] < array[i])
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        public static int SumOddIndexArray(int sizeArray = 5, int startRandomNumber = -10, int lastRandomNumber = 10)
        {
            int[] array = FillingArray(sizeArray, startRandomNumber, lastRandomNumber);
            int sumOddI = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOddI += array[i];
                }
            }

            return sumOddI;
        }

        public static int[] ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }

            return array;
        }

        public static int SumOddValueInArray(int[] array)
        {
            int sumOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumOdd += array[i];
                }
            }

            return sumOdd;
        }

        public static int[] HalfReverseArray(int[] array)
        {
            int startPosition = array.Length / 2 + array.Length % 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[startPosition + i]);
            }

            return array;
        }

        public static int[] BubbleSortAsc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        public static int[] SelectionSortDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[max] < array[j])
                    {
                        max = j;
                    }
                }

                Swap(ref array[i], ref array[max]);
            }

            return array;
        }

        public static int[] FillingArray(int sizeArray = 5, int startRandomNumber = -10, int lastRandomNumber = 10)
        {
            int[] array = new int[sizeArray];

            Random randomNumber = new Random();
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = randomNumber.Next(startRandomNumber, lastRandomNumber);
            }

            return array;
        }
    }
}
