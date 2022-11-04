using System.Collections.Generic;

namespace Algorithms
{
    public class bubble_Sort
    {
        public static List<int> sort(List<int> ints)
        {
            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 1; i < ints.Count; i++)
                {
                    if (ints[i] < ints[i - 1])
                    {
                        ints[i - 1] ^= ints[i];
                        ints[i] = ints[i - 1] ^ ints[i];
                        ints[i - 1] ^= ints[i];
                        changed = true;
                    }
                }
            }

            return ints;
        }
    }
}