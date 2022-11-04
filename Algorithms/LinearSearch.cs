using System.Collections.Generic;

namespace Algorithms
{
    public class LinearSearch
    {
        /// <summary>
        /// performs linear search using a for loop
        /// </summary>
        /// <param name="ints">list of integers</param>
        /// <param name="goal">the number you are looking for</param>
        /// <returns>the integer corresponding to the index of the searched for number</returns>
        public static int search(List<int> ints, int goal)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] == goal)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}