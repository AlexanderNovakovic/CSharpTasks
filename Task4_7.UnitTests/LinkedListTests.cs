using System.Collections.Generic;
using Xunit;

namespace Task4_7.UnitTests
{
    public class LinkedListTests
    {
        [Theory]
        [MemberData(nameof(AddFirstTestParams))]
        public void AddFirstTests(int number, int[] numbers, int expected)
        {
            ListOfElements list = new ListOfElements(number);

            foreach (int n in numbers)
            {
                list.AddFirst(n);
            }

            Assert.Equal(expected, list.First.Number);
            Assert.Equal(numbers[numbers.Length - 2], list.First.Next.Number);            
        }

        public static IEnumerable<object[]> AddFirstTestParams()
        {
            yield return new object[]
            {
                0,
                new int[] { 1, 2, 3, 4 },
                4              
            };

            yield return new object[]
            {
                0,
                new int[] { 7, 16, 3, 28 },
                28
            };
        }

        [Theory]
        [MemberData(nameof(AddLastTestParams))]
        public void AddLastTests(int number, int[] numbers, int expected)
        {
            ListOfElements list = new ListOfElements(number);

            foreach (int n in numbers)
            {
                list.AddLast(n);
            }

            Assert.Equal(expected, list.First.Number);
            Assert.Equal(numbers[0], list.First.Next.Number);
        }

        public static IEnumerable<object[]> AddLastTestParams()
        {
            yield return new object[]
            {
                0,
                new int[] { 1, 2, 3, 4 },
                0
            };

            yield return new object[]
            {
                12,
                new int[] { 7, 16, 3, 28 },
                12
            };
        }

        [Theory]
        [MemberData(nameof(InsertTestParams))]
        public void InsertTests(int number, int[] numbers, int expected)
        {
            ListOfElements list = new ListOfElements();

            foreach (int n in numbers)
            {
                list.AddLast(n);
            }

            list.Insert(number);

            Assert.Equal(expected, list.First.Next.Next.Next.Number);
            Assert.Equal(expected, list.First.Next.Next.Number);
        }

        public static IEnumerable<object[]> InsertTestParams()
        {
            yield return new object[]
            {
                3,
                new int[] { 1, 2, 3, 4 },
                3
            };            
        }
    }
}
