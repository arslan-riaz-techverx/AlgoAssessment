using System;
using System.Linq;

namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
        private readonly int maxArrayLength = 100000;
        public int Find(int[] numbers)
      {
            if (numbers.Length > maxArrayLength)
            {
                throw new ArgumentOutOfRangeException();
            }
            int total = numbers.Sum();
            int current = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total -= numbers[i];

                if (current == total)
                {
                    return i;
                }

                current += numbers[i];
            }
            return -1;
        }
    }
}
