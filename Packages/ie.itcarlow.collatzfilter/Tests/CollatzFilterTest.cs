using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CollatzFilterTest
    {
        [Test]
        public void CollatzFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 6 };
            int[] output = CollatzFilter.collatz(input);
            int[] expected = { 2, 1, 4, 10, 28, 2, 5, 3 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
