using NUnit.Framework;
using OneDimensionalArrays;
using System;

namespace OneDimensionalArraysLibrary_Tests
{
    public class OneDimensionalArraysLibraryTests
    {
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 1 }, 1)]
        [TestCase(new int[] { -4, 1, 2 }, -4)]
        [TestCase(new int[] { 1, -5, 2 }, -5)]
        [TestCase(new int[] { 12, 24, 10 }, 10)]
        public void FindMinimumValueInArray(int[] array, int expected)
        {
            int actual = OneDimensionalArraysLibrary.MinimumArrayValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 1 }, 1)]
        [TestCase(new int[] { -4, 1, 2 }, 2)]
        [TestCase(new int[] { 1, -5, -2 }, 1)]
        [TestCase(new int[] { 12, 24, 10 }, 24)]
        public void FindMaximumValueInArray(int[] array, int expected)
        {
            int actual = OneDimensionalArraysLibrary.MaximumArrayValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public void FindMinimumValueInArray_WhenArrayIsEmptyOrNull_ShouldException(int[] array)
        {
            try
            {
                OneDimensionalArraysLibrary.MinimumArrayValue(array);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No minimum value in empty array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public void FindMaximumValueInArray_WhenArrayIsEmptyOrNull_ShouldException(int[] array)
        {
            try
            {
                OneDimensionalArraysLibrary.MaximumArrayValue(array);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No maximum value in empty array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        [TestCase(new int[] { 1, 2 })]
        public void HalfReverseArray_WhenArrayIsEmptyOrNullOrFewElements_ShouldException(int[] array)
        {
            try
            {
                OneDimensionalArraysLibrary.HalfReverseArray(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Some method received a null argument", ex.Message);
                Assert.Pass();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Few elements in the array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}