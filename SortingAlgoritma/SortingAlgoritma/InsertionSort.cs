using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritma
{
    public class InsertionSort:SortBase
    {

        public override void Sort(int[] items)
        {
            int i, j, moved;
            for (i = 1; i < items.Length; i++)
            {
                moved = items[i];
                j = i;
                while (j > 0 && items[j - 1] > moved)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = moved;
            }
        }

    }
}
