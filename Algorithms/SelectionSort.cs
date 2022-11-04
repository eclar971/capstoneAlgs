using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Algorithms
{
    public class SelectionSort
    {
        public static List<int> sort(List<int> ints)
        {
            
            int swappedIndex = 0;
            for (int j = 0;j < ints.Count; j++)
            {
                for (int i = j + 1; i < ints.Count; i++)
                {
                    if (ints[i] < ints[swappedIndex])
                    {
                        swappedIndex = i;
                    }
                }

                if (ints[j] != ints[swappedIndex] && ints[swappedIndex] < ints[j])
                {
                    (ints[j], ints[swappedIndex]) = (ints[swappedIndex], ints[j]);
                }

                
            }

            return ints;
        } 
    }
}